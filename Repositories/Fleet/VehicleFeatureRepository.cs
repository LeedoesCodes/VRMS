using System.Data;
using VRMS.Database;
using VRMS.Models.Fleet;

namespace VRMS.Repositories.Fleet;

public class VehicleFeatureRepository
{
    public int Create(string name)
    {
        var table = DB.Query(
            "CALL sp_vehicle_features_create(@name);",
            ("@name", name)
        );
        return Convert.ToInt32(table.Rows[0]["feature_id"]);
    }

    public void Update(int id, string name)
    {
        DB.Execute(
            "CALL sp_vehicle_features_update(@id,@name);",
            ("@id", id),
            ("@name", name)
        );
    }

    public void Delete(int id)
    {
        DB.Execute(
            "CALL sp_vehicle_features_delete(@id);",
            ("@id", id)
        );
    }

    public VehicleFeature GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_vehicle_features_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Feature not found.");

        return new VehicleFeature
        {
            Id = Convert.ToInt32(table.Rows[0]["id"]),
            Name = table.Rows[0]["name"].ToString()!
        };
    }

    public List<VehicleFeature> GetAll()
    {
        var table = DB.Query("CALL sp_vehicle_features_get_all();");
        var list = new List<VehicleFeature>();

        foreach (DataRow r in table.Rows)
            list.Add(new VehicleFeature
            {
                Id = Convert.ToInt32(r["id"]),
                Name = r["name"].ToString()!
            });

        return list;
    }
}