using VRMS.Database.StoredProcedureImplementations.Damages.Damage;

namespace VRMS.Database.Migrations;

public static class M_1011_CreateDamageProcedures
{
    public static string Create() => $"""
                                      {SP_Damages_Create.Sql()}
                                      {SP_Damages_GetById.Sql()}
                                      {SP_Damages_GetAll.Sql()}
                                      {SP_Damages_Update.Sql()}
                                      {SP_Damages_Delete.Sql()}
                                      """;

    public static string Drop() => """
                                   DROP PROCEDURE IF EXISTS sp_damages_create;
                                   DROP PROCEDURE IF EXISTS sp_damages_get_by_id;
                                   DROP PROCEDURE IF EXISTS sp_damages_get_all;
                                   DROP PROCEDURE IF EXISTS sp_damages_update;
                                   DROP PROCEDURE IF EXISTS sp_damages_delete;
                                   """;
}