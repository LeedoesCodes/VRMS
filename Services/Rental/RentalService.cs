using VRMS.Enums;
using VRMS.Repositories.Rentals;
using VRMS.Services.Fleet;

namespace VRMS.Services.Rental;

public class RentalService
{
    private readonly ReservationService _reservationService;
    private readonly VehicleService _vehicleService;
    private readonly RentalRepository _rentalRepo;

    public RentalService(
        ReservationService reservationService,
        VehicleService vehicleService,
        RentalRepository rentalRepo)
    {
        _reservationService = reservationService;
        _vehicleService = vehicleService;
        _rentalRepo = rentalRepo;
    }

    // -------------------------------------------------
    // START RENTAL (PICKUP)
    // -------------------------------------------------

    public int StartRental(
        int reservationId,
        DateTime pickupDate)
    {
        var reservation =
            _reservationService
                .GetReservationById(reservationId);

        if (reservation.Status !=
            ReservationStatus.Confirmed)
            throw new InvalidOperationException(
                "Reservation must be confirmed before starting a rental.");

        if (pickupDate < reservation.StartDate)
            throw new InvalidOperationException(
                "Pickup date cannot be before reservation start date.");

        if (_rentalRepo.GetByReservation(reservationId)
            != null)
            throw new InvalidOperationException(
                "A rental already exists for this reservation.");

        var vehicle =
            _vehicleService.GetVehicleById(
                reservation.VehicleId);

        if (vehicle.Status != VehicleStatus.Reserved)
            throw new InvalidOperationException(
                "Vehicle must be reserved before starting rental.");

        var rentalId =
            _rentalRepo.Create(
                reservationId,
                pickupDate,
                reservation.EndDate,
                vehicle.Odometer,
                RentalStatus.Active);

        _rentalRepo.MarkStarted(rentalId);

        _vehicleService.UpdateVehicleStatus(
            reservation.VehicleId,
            VehicleStatus.Rented);

        return rentalId;
    }

    // -------------------------------------------------
    // COMPLETE RENTAL (RETURN)
    // -------------------------------------------------

    public void CompleteRental(
        int rentalId,
        DateTime actualReturnDate,
        int endOdometer)
    {
        var rental =
            _rentalRepo.GetById(rentalId);

        if (rental.Status != RentalStatus.Active)
            throw new InvalidOperationException(
                "Only active rentals can be completed.");

        if (actualReturnDate < rental.PickupDate)
            throw new InvalidOperationException(
                "Return date cannot be before pickup date.");

        if (endOdometer <= rental.StartOdometer)
            throw new InvalidOperationException(
                "End odometer must be greater than start odometer.");

        _rentalRepo.Complete(
            rentalId,
            actualReturnDate,
            endOdometer);

        if (actualReturnDate >
            rental.ExpectedReturnDate)
        {
            _rentalRepo.UpdateStatus(
                rentalId,
                RentalStatus.Late);
        }

        var reservation =
            _reservationService
                .GetReservationById(
                    rental.ReservationId);

        var vehicle =
            _vehicleService
                .GetVehicleById(
                    reservation.VehicleId);

        _vehicleService.UpdateVehicle(
            vehicleId: reservation.VehicleId,
            color: vehicle.Color,
            newOdometer: endOdometer,
            fuelEfficiency: vehicle.FuelEfficiency,
            cargoCapacity: vehicle.CargoCapacity,
            categoryId: vehicle.VehicleCategoryId);

        _vehicleService.UpdateVehicleStatus(
            reservation.VehicleId,
            VehicleStatus.Available);
    }

    // -------------------------------------------------
    // READ
    // -------------------------------------------------

    public Models.Rentals.Rental GetRentalById(int rentalId)
        => _rentalRepo.GetById(rentalId);

    public Models.Rentals.Rental? GetRentalByReservation(
        int reservationId)
        => _rentalRepo.GetByReservation(reservationId);
}
