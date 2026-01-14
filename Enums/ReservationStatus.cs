namespace VRMS.Enums;

public enum ReservationStatus
{
    Pending,     // created, NOT paid
    Confirmed,   // reservation fee paid, vehicle reserved
    Rented,      // reservation has been converted into a rental
    Cancelled
}