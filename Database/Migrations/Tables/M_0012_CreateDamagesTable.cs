using VRMS.Database.DBHelpers.EnumHelper;
using VRMS.Enums;

namespace VRMS.Database.Migrations.Tables;

public static class M_0012_CreateDamagesTable
{
    public static string Create() => $"""
                                      CREATE TABLE IF NOT EXISTS damages (
                                          id INT AUTO_INCREMENT PRIMARY KEY,
                                          damage_type {Tbl.ToEnum<DamageType>()} NOT NULL,
                                          description TEXT NOT NULL,
                                          estimated_cost DECIMAL(10,2) NOT NULL
                                      ) ENGINE=InnoDB;
                                      """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS damages;
                                   """;
}
