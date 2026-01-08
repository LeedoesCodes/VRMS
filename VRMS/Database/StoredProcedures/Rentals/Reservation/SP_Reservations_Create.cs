namespace VRMS.Database.StoredProcedures.Rentals.Reservation;

public static class SP_Reservations_Create
{
    public static string Sql() => """
                                  DROP PROCEDURE IF EXISTS sp_reservations_create;

                                  CREATE PROCEDURE sp_reservations_create (
                                      IN p_customer_id INT,
                                      IN p_vehicle_id INT,
                                      IN p_start_date DATETIME,
                                      IN p_end_date DATETIME,
                                      IN p_status ENUM('Pending','Confirmed','Cancelled','Completed')
                                  )
                                  BEGIN
                                      INSERT INTO reservations (
                                          customer_id,
                                          vehicle_id,
                                          start_date,
                                          end_date,
                                          status
                                      )
                                      VALUES (
                                          p_customer_id,
                                          p_vehicle_id,
                                          p_start_date,
                                          p_end_date,
                                          p_status
                                      );

                                      SELECT LAST_INSERT_ID() AS reservation_id;
                                  END;
                                  """;
}