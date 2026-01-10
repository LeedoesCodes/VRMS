namespace VRMS.Database.StoredProcedureImplementations.Rentals.Reservation;

public static class SP_Reservations_GetByVehicle
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_get_by_vehicle;

                                  CREATE PROCEDURE sp_reservations_get_by_vehicle (
                                      IN p_vehicle_id INT
                                  )
                                  BEGIN
                                      SELECT
                                          id,
                                          customer_id,
                                          vehicle_id,
                                          start_date,
                                          end_date,
                                          status
                                      FROM reservations
                                      WHERE vehicle_id = p_vehicle_id
                                      ORDER BY start_date DESC;
                                  END;
                                  """;
}