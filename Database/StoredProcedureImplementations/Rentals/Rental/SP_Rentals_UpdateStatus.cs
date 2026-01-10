namespace VRMS.Database.StoredProcedureImplementations.Rentals.Rental;

public static class SP_Rentals_UpdateStatus
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_rentals_update_status;

                                  CREATE PROCEDURE sp_rentals_update_status (
                                      IN p_rental_id INT,
                                      IN p_status VARCHAR(50)
                                  )
                                  BEGIN
                                      UPDATE rentals
                                      SET status = p_status
                                      WHERE id = p_rental_id;
                                  END;
                                  """;
}