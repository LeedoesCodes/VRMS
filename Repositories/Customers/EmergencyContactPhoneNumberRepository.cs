using System;
using System.Collections.Generic;
using System.Data;
using VRMS.Database;

namespace VRMS.Repositories.Customers;

public class EmergencyContactPhoneNumberRepository
{
    // ----------------------------
    // PHONE NUMBERS
    // ----------------------------

    public int Create(int emergencyContactId, string phoneNumber)
    {
        var table = DB.Query(
            "CALL sp_emergency_contact_phone_numbers_create(@contactId, @phone);",
            ("@contactId", emergencyContactId),
            ("@phone", phoneNumber)
        );

        return Convert.ToInt32(table.Rows[0]["phone_number_id"]);
    }

    public void Update(int phoneNumberId, string phoneNumber)
    {
        DB.Execute(
            "CALL sp_emergency_contact_phone_numbers_update(@id, @phone);",
            ("@id", phoneNumberId),
            ("@phone", phoneNumber)
        );
    }

    public void Delete(int phoneNumberId)
    {
        DB.Execute(
            "CALL sp_emergency_contact_phone_numbers_delete(@id);",
            ("@id", phoneNumberId)
        );
    }

    public List<string> GetByEmergencyContactId(int emergencyContactId)
    {
        var table = DB.Query(
            "CALL sp_emergency_contact_phone_numbers_get_by_contact_id(@contactId);",
            ("@contactId", emergencyContactId)
        );

        var list = new List<string>();
        foreach (DataRow row in table.Rows)
            list.Add(row["phone_number"].ToString()!);

        return list;
    }
}