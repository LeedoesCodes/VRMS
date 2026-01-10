namespace VRMS.Database.StoredProcedureImplementations.Rentals.Reservation;

public static class SP_Reservations_UpdateStatus
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_update_status;

                                  CREATE PROCEDURE sp_reservations_update_status (
                                      IN p_reservation_id INT,
                                      IN p_status VARCHAR(50)
                                  )
                                  BEGIN
                                      UPDATE reservations
                                      SET status = p_status
                                      WHERE id = p_reservation_id;
                                  END;
                                  """;
}