using System;
using System.Collections.Generic;
using System.Data;
using VRMS.Database;
using VRMS.Models.Customers;

namespace VRMS.Repositories.Customers;

public class EmergencyContactRepository
{
    // ----------------------------
    // EMERGENCY CONTACTS
    // ----------------------------

    public int Create(
        int customerId,
        string firstName,
        string lastName,
        string relationship
    )
    {
        var table = DB.Query(
            "CALL sp_emergency_contacts_create(@customerId, @first, @last, @relationship);",
            ("@customerId", customerId),
            ("@first", firstName),
            ("@last", lastName),
            ("@relationship", relationship)
        );

        return Convert.ToInt32(table.Rows[0]["emergency_contact_id"]);
    }

    public void Update(
        int emergencyContactId,
        string firstName,
        string lastName,
        string relationship
    )
    {
        DB.Execute(
            "CALL sp_emergency_contacts_update(@id, @first, @last, @relationship);",
            ("@id", emergencyContactId),
            ("@first", firstName),
            ("@last", lastName),
            ("@relationship", relationship)
        );
    }

    public void Delete(int emergencyContactId)
    {
        DB.Execute(
            "CALL sp_emergency_contacts_delete(@id);",
            ("@id", emergencyContactId)
        );
    }

    public List<EmergencyContact> GetByCustomerId(int customerId)
    {
        var table = DB.Query(
            "CALL sp_emergency_contacts_get_by_customer_id(@customerId);",
            ("@customerId", customerId)
        );

        var list = new List<EmergencyContact>();
        foreach (DataRow row in table.Rows)
            list.Add(Map(row));

        return list;
    }

    // ----------------------------
    // MAPPING
    // ----------------------------
    private static EmergencyContact Map(DataRow row)
    {
        return new EmergencyContact
        {
            Id = Convert.ToInt32(row["id"]),
            CustomerId = Convert.ToInt32(row["customer_id"]),
            FirstName = row["first_name"].ToString()!,
            LastName = row["last_name"].ToString()!,
            Relationship = row["relationship"].ToString()!
        };
    }
}
