using VRMS.Database.DBHelpers.EnumHelper;
using VRMS.Enums;

namespace VRMS.Database.Migrations.Tables;

public static class M_0010_CreateRentalsTable
{
    public static string Create() => $"""
                                      CREATE TABLE IF NOT EXISTS rentals (
                                          id INT AUTO_INCREMENT PRIMARY KEY,

                                          -- CUSTOMER OWNS THE RENTAL (even for walk-ins)
                                          customer_id INT NOT NULL,

                                          -- REQUIRED vehicle
                                          vehicle_id INT NOT NULL,

                                          pickup_date DATETIME NOT NULL,
                                          expected_return_date DATETIME NOT NULL,
                                          actual_return_date DATETIME NULL,

                                          start_odometer INT NOT NULL,
                                          end_odometer INT NULL,

                                          start_fuel_level {Tbl.ToEnum<FuelLevel>()} NOT NULL,
                                          end_fuel_level {Tbl.ToEnum<FuelLevel>()} NULL,

                                          status {Tbl.ToEnum<RentalStatus>()} NOT NULL,

                                          CONSTRAINT fk_rentals_customer
                                              FOREIGN KEY (customer_id)
                                              REFERENCES customers(id)
                                              ON DELETE RESTRICT,

                                          CONSTRAINT fk_rentals_vehicle
                                              FOREIGN KEY (vehicle_id)
                                              REFERENCES vehicles(id)
                                              ON DELETE RESTRICT
                                      ) ENGINE=InnoDB;
                                      """;

    public static string Drop() => """
                                   DROP TABLE IF EXISTS rentals;
                                   """;
}