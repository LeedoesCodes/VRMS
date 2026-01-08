using VRMS.Database.StoredProcedures.Rentals.Reservation;

namespace VRMS.Database.Migrations;

public static class M_1008_CreateReservationProcedures
{
    public static string Create() => $"""
                                      {SP_Reservations_Create.Sql()}
                                      {SP_Reservations_GetById.Sql()}
                                      {SP_Reservations_GetByCustomer.Sql()}
                                      {SP_Reservations_GetByVehicle.Sql()}
                                      {SP_Reservations_UpdateStatus.Sql()}
                                      {SP_Reservations_Cancel.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_reservations_create;
                                   DROP PROCEDURE IF EXISTS sp_reservations_get_by_id;
                                   DROP PROCEDURE IF EXISTS sp_reservations_get_by_customer;
                                   DROP PROCEDURE IF EXISTS sp_reservations_get_by_vehicle;
                                   DROP PROCEDURE IF EXISTS sp_reservations_update_status;
                                   DROP PROCEDURE IF EXISTS sp_reservations_cancel;
                                   """;
}