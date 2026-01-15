using VRMS.Database.SPImplementations.System;

namespace VRMS.Database.Migrations.StoredProcedures;

public static class M_1024_CreateSystemActivityLogProcedures
{
    public static string Create() => $"""
                                          {SP_SystemActivityLogs_Create.Sql()}
                                      """;

    public static string Drop() => """
                                       DROP PROCEDURE IF EXISTS sp_system_activity_logs_create;
                                   """;
}