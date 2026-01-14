using VRMS.DTOs.Reservation;
using VRMS.Enums;
using VRMS.Models.Rentals;
using VRMS.Repositories.Rentals;
using VRMS.Services.Billing;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;

namespace VRMS.Services.Rental;

/// <summary>
/// Provides business logic for reservation lifecycle management, including:
/// - Reservation creation with eligibility checks
/// - Confirmation and cancellation workflows
/// - Vehicle availability locking and releasing
/// - Reservation overlap prevention
///
/// This service enforces strict reservation state transitions
/// and coordinates customer eligibility and vehicle availability.
/// </summary>
public class ReservationService
{
    private readonly RateService _rateService;
    
    /// <summary>
    /// Customer service used to validate rental eligibility.
    /// </summary>
    private readonly CustomerService _customerService;

    /// <summary>
    /// Vehicle service used for vehicle availability and status updates.
    /// </summary>
    private readonly VehicleService _vehicleService;

    /// <summary>
    /// Reservation repository for persistence.
    /// </summary>
    private readonly ReservationRepository _reservationRepo;

    /// <summary>
    /// Initializes the reservation service with required dependencies.
    /// </summary>
    public ReservationService(
        CustomerService customerService,
        VehicleService vehicleService,
        ReservationRepository reservationRepo,
        RateService rateService)
    {
        _customerService = customerService;
        _vehicleService = vehicleService;
        _reservationRepo = reservationRepo;
        _rateService = rateService;
    }



    // -------------------------------------------------
    // CREATE
    // -------------------------------------------------

    /// <summary>
    /// Creates a new reservation in a pending state.
    ///
    /// This operation:
    /// - Validates reservation date range
    /// - Ensures customer eligibility to rent
    /// - Ensures vehicle availability
    /// - Prevents overlapping reservations
    /// </summary>
    /// <param name="customerId">Customer ID</param>
    /// <param name="vehicleId">Vehicle ID</param>
    /// <param name="startDate">Reservation start date</param>
    /// <param name="endDate">Reservation end date</param>
    /// <returns>Newly created reservation ID</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when eligibility, availability, or overlap rules are violated
    /// </exception>
    public int CreateReservation(
        int customerId,
        int vehicleId,
        DateTime startDate,
        DateTime endDate)
    {
        if (startDate >= endDate)
            throw new InvalidOperationException(
                "Start date must be before end date.");

        // Customer eligibility
        _customerService.EnsureCustomerCanRent(
            customerId,
            startDate);

        // Vehicle eligibility
        var vehicle =
            _vehicleService.GetVehicleById(vehicleId);

        if (vehicle.Status != VehicleStatus.Available)
            throw new InvalidOperationException(
                "Vehicle is not available for reservation.");

        // Overlap check
        EnsureNoOverlap(
            vehicleId,
            startDate,
            endDate);
        

        // Estimated rental using authoritative pricing logic
        decimal estimatedRental =
            _rateService.CalculateRentalCost(
                startDate,
                endDate,
                vehicle.VehicleCategoryId);

        // Reservation fee (20%)
        const decimal reservationFeeRate = 0.20m;

        decimal reservationFee =
            decimal.Round(
                estimatedRental * reservationFeeRate,
                2);

        // Persist reservation
        return _reservationRepo.Create(
            customerId,
            vehicleId,
            startDate,
            endDate,
            estimatedRental,
            reservationFee,
            reservationFeeRate,
            ReservationStatus.Pending);


    }

    // -------------------------------------------------
    // CONFIRM / CANCEL
    // -------------------------------------------------

    /// <summary>
    /// Confirms a pending reservation.
    ///
    /// This operation:
    /// - Validates reservation state transition
    /// - Re-checks reservation overlap
    /// - Locks the associated vehicle as reserved
    /// </summary>
    /// <param name="reservationId">Reservation ID</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the status transition or overlap check fails
    /// </exception>
    public void ConfirmReservation(int reservationId)
    {
        var reservation =
            _reservationRepo.GetById(reservationId);

        EnsureStatusTransition(
            reservation.Status,
            ReservationStatus.Confirmed);

        // Re-check overlap
        EnsureNoOverlap(
            reservation.VehicleId,
            reservation.StartDate,
            reservation.EndDate,
            reservation.Id);

        if (reservation.ReservationFeeAmount > 0m &&
            !_reservationRepo.IsReservationFeePaid(reservation.Id))
        {
            throw new InvalidOperationException(
                "Reservation fee must be paid before confirmation.");
        }
        
        // Lock vehicle
        _vehicleService.UpdateVehicleStatus(
            reservation.VehicleId,
            VehicleStatus.Reserved);

        _reservationRepo.UpdateStatus(
            reservationId,
            ReservationStatus.Confirmed);
    }
    
    /// <summary>
    /// Marks a confirmed reservation as rented.
    /// Called when a rental is successfully started.
    /// </summary>
    public void MarkReservationAsRented(int reservationId)
    {
        var reservation =
            _reservationRepo.GetById(reservationId);

        EnsureStatusTransition(
            reservation.Status,
            ReservationStatus.Rented);

        _reservationRepo.UpdateStatus(
            reservationId,
            ReservationStatus.Rented);
    }

    /// <summary>
    /// Cancels a reservation.
    ///
    /// If the reservation was confirmed, the vehicle is released
    /// only if no other active reservations exist for the vehicle.
    /// </summary>
    /// <param name="reservationId">Reservation ID</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the status transition is invalid
    /// </exception>
    public void CancelReservation(int reservationId)
    {
        var reservation =
            _reservationRepo.GetById(reservationId);

        EnsureStatusTransition(
            reservation.Status,
            ReservationStatus.Cancelled);

        _reservationRepo.Cancel(reservationId);

        // Release vehicle if no other active reservations exist
        if (reservation.Status ==
            ReservationStatus.Confirmed)
        {
            if (!HasActiveReservations(
                    reservation.VehicleId,
                    reservation.Id))
            {
                _vehicleService.UpdateVehicleStatus(
                    reservation.VehicleId,
                    VehicleStatus.Available);
            }
        }
    }

    // -------------------------------------------------
    // READ
    // -------------------------------------------------

    /// <summary>
    /// Retrieves a reservation by ID.
    /// </summary>
    public Reservation GetReservationById(
        int reservationId)
        => _reservationRepo.GetById(
            reservationId);

    /// <summary>
    /// Retrieves all reservations for a customer.
    /// </summary>
    public List<Reservation> GetReservationsByCustomer(
        int customerId)
        => _reservationRepo.GetByCustomer(
            customerId);

    /// <summary>
    /// Retrieves all reservations for a vehicle.
    /// </summary>
    public List<Reservation> GetReservationsByVehicle(
        int vehicleId)
        => _reservationRepo.GetByVehicle(
            vehicleId);

    // -------------------------------------------------
    // INTERNAL RULES
    // -------------------------------------------------

    /// <summary>
    /// Ensures that a reservation status transition is legal.
    ///
    /// Valid transitions:
    /// - Pending → Confirmed / Cancelled
    /// - Confirmed → Cancelled
    /// - Cancelled → (no transitions)
    /// </summary>
    private void EnsureStatusTransition(
        ReservationStatus current,
        ReservationStatus next)
    {
        bool valid = current switch
        {
            ReservationStatus.Pending =>
                next is ReservationStatus.Confirmed
                    or ReservationStatus.Cancelled,

            ReservationStatus.Confirmed =>
                next is ReservationStatus.Rented
                    or ReservationStatus.Cancelled,

            ReservationStatus.Rented =>
                false, // terminal state

            ReservationStatus.Cancelled =>
                false,

            _ => false
        };

        if (!valid)
            throw new InvalidOperationException(
                $"Illegal reservation status transition: {current} → {next}");
    }


    /// <summary>
    /// Ensures that a reservation does not overlap with existing
    /// non-cancelled reservations for the same vehicle.
    /// </summary>
    private void EnsureNoOverlap(
        int vehicleId,
        DateTime start,
        DateTime end,
        int? ignoreReservationId = null)
    {
        var reservations =
            _reservationRepo.GetByVehicle(vehicleId);

        foreach (var r in reservations)
        {
            if (ignoreReservationId.HasValue
                && r.Id == ignoreReservationId.Value)
                continue;

            if (r.Status ==
                ReservationStatus.Cancelled)
                continue;

            bool overlaps =
                start < r.EndDate &&
                end > r.StartDate;

            if (overlaps)
                throw new InvalidOperationException(
                    "Reservation overlaps with an existing reservation.");
        }
    }

    /// <summary>
    /// Determines whether a vehicle has other active reservations.
    /// </summary>
    private bool HasActiveReservations(
        int vehicleId,
        int excludingReservationId)
    {
        var reservations =
            _reservationRepo.GetByVehicle(vehicleId);

        foreach (var r in reservations)
        {
            if (r.Id == excludingReservationId)
                continue;

            if (r.Status is
                ReservationStatus.Pending
                or ReservationStatus.Confirmed)
                return true;
        }

        return false;
    }
    public List<ReservationGridRow> GetAllForGrid()
    {
        return _reservationRepo.GetAllForGrid();
    }
}
