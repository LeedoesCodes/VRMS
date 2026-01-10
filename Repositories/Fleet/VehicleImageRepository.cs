using System.Data;
using VRMS.Database;
using VRMS.Models.Fleet;

namespace VRMS.Repositories.Fleet;

public class VehicleImageRepository
{
    public void Create(int vehicleId, string path)
    {
        DB.Execute(
            "CALL sp_vehicle_images_create(@vid,@path);",
            ("@vid", vehicleId),
            ("@path", path)
        );
    }

    public VehicleImage GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_vehicle_images_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Image not found.");

        var r = table.Rows[0];
        return new VehicleImage
        {
            Id = Convert.ToInt32(r["id"]),
            VehicleId = Convert.ToInt32(r["vehicle_id"]),
            ImagePath = r["image_path"].ToString()!
        };
    }

    public void Delete(int id)
    {
        DB.Execute(
            "CALL sp_vehicle_images_delete(@id);",
            ("@id", id)
        );
    }

    public List<VehicleImage> GetByVehicle(int vehicleId)
    {
        var table = DB.Query(
            "CALL sp_vehicle_images_get_by_vehicle_id(@id);",
            ("@id", vehicleId)
        );

        var list = new List<VehicleImage>();
        foreach (DataRow r in table.Rows)
            list.Add(new VehicleImage
            {
                Id = Convert.ToInt32(r["id"]),
                VehicleId = Convert.ToInt32(r["vehicle_id"]),
                ImagePath = r["image_path"].ToString()!
            });

        return list;
    }
}