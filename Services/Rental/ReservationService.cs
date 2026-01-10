using VRMS.Enums;
using VRMS.Models.Rentals;
using VRMS.Repositories.Rentals;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;

namespace VRMS.Services.Rental;

public class ReservationService
{
    private readonly CustomerService _customerService;
    private readonly VehicleService _vehicleService;
    private readonly ReservationRepository _reservationRepo;

    public ReservationService(
        CustomerService customerService,
        VehicleService vehicleService,
        ReservationRepository reservationRepo)
    {
        _customerService = customerService;
        _vehicleService = vehicleService;
        _reservationRepo = reservationRepo;
    }

    // -------------------------------------------------
    // CREATE
    // -------------------------------------------------

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

        return _reservationRepo.Create(
            customerId,
            vehicleId,
            startDate,
            endDate,
            ReservationStatus.Pending);
    }

    // -------------------------------------------------
    // CONFIRM / CANCEL
    // -------------------------------------------------

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

        // Lock vehicle
        _vehicleService.UpdateVehicleStatus(
            reservation.VehicleId,
            VehicleStatus.Reserved);

        _reservationRepo.UpdateStatus(
            reservationId,
            ReservationStatus.Confirmed);
    }

    public void CancelReservation(int reservationId)
    {
        var reservation =
            _reservationRepo.GetById(reservationId);

        EnsureStatusTransition(
            reservation.Status,
            ReservationStatus.Cancelled);

        _reservationRepo.Cancel(reservationId);

        // Release vehicle if no other active reservations
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

    public Reservation GetReservationById(
        int reservationId)
        => _reservationRepo.GetById(
            reservationId);

    public List<Reservation> GetReservationsByCustomer(
        int customerId)
        => _reservationRepo.GetByCustomer(
            customerId);

    public List<Reservation> GetReservationsByVehicle(
        int vehicleId)
        => _reservationRepo.GetByVehicle(
            vehicleId);

    // -------------------------------------------------
    // INTERNAL RULES
    // -------------------------------------------------

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
                next is ReservationStatus.Cancelled,

            ReservationStatus.Cancelled =>
                false,

            _ => false
        };

        if (!valid)
            throw new InvalidOperationException(
                $"Illegal reservation status transition: {current} → {next}");
    }

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
}
