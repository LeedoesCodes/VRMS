using System.Data;
using VRMS.Database;
using VRMS.Models.Fleet;

namespace VRMS.Repositories.Fleet;

public class VehicleFeatureMappingRepository
{
    public void Add(int vehicleId, int featureId)
    {
        DB.Execute(
            "CALL sp_vehicle_feature_mappings_add(@vid,@fid);",
            ("@vid", vehicleId),
            ("@fid", featureId)
        );
    }

    public void Remove(int vehicleId, int featureId)
    {
        DB.Execute(
            "CALL sp_vehicle_feature_mappings_remove(@vid,@fid);",
            ("@vid", vehicleId),
            ("@fid", featureId)
        );
    }

    public List<VehicleFeature> GetByVehicle(int vehicleId)
    {
        var table = DB.Query(
            "CALL sp_vehicle_feature_mappings_get_by_vehicle(@id);",
            ("@id", vehicleId)
        );

        var list = new List<VehicleFeature>();
        foreach (DataRow r in table.Rows)
            list.Add(new VehicleFeature
            {
                Id = Convert.ToInt32(r["feature_id"]),
                Name = r["feature_name"].ToString()!
            });

        return list;
    }
}