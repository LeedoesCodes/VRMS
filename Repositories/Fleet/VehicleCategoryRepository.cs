using System.Data;
using VRMS.Database;
using VRMS.Models.Fleet;

namespace VRMS.Repositories.Fleet;

public class VehicleCategoryRepository
{
    public int Create(string name, string? desc)
    {
        var table = DB.Query(
            "CALL sp_vehicle_categories_create(@name,@desc);",
            ("@name", name),
            ("@desc", desc)
        );
        return Convert.ToInt32(table.Rows[0]["category_id"]);
    }

    public void Update(int id, string name, string? desc)
    {
        DB.Execute(
            "CALL sp_vehicle_categories_update(@id,@name,@desc);",
            ("@id", id),
            ("@name", name),
            ("@desc", desc)
        );
    }

    public void Delete(int id)
    {
        DB.Execute(
            "CALL sp_vehicle_categories_delete(@id);",
            ("@id", id)
        );
    }

    public VehicleCategory GetById(int id)
    {
        var table = DB.Query(
            "CALL sp_vehicle_categories_get_by_id(@id);",
            ("@id", id)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Category not found.");

        var r = table.Rows[0];
        return new VehicleCategory
        {
            Id = Convert.ToInt32(r["id"]),
            Name = r["name"].ToString()!,
            Description = r["description"] as string
        };
    }

    public List<VehicleCategory> GetAll()
    {
        var table = DB.Query("CALL sp_vehicle_categories_get_all();");
        var list = new List<VehicleCategory>();

        foreach (DataRow r in table.Rows)
            list.Add(new VehicleCategory
            {
                Id = Convert.ToInt32(r["id"]),
                Name = r["name"].ToString()!,
                Description = r["description"] as string
            });

        return list;
    }
}