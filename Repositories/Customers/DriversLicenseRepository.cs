using System;
using System.Data;
using VRMS.Database;
using VRMS.Models.Customers;

namespace VRMS.Repositories.Customers;

public class DriversLicenseRepository
{
    private const string DefaultDriversLicensePhotoPath = "Assets/img_placeholder.png";

    // ----------------------------
    // CREATE
    // ----------------------------
    public int Create(
        string licenseNumber,
        DateTime issueDate,
        DateTime expiryDate,
        string issuingCountry
    )
    {
        var table = DB.Query(
            "CALL sp_drivers_licenses_create(@number, @issue, @expiry, @country, @front, @back);",
            ("@number", licenseNumber),
            ("@issue", issueDate),
            ("@expiry", expiryDate),
            ("@country", issuingCountry),
            ("@front", DefaultDriversLicensePhotoPath),
            ("@back", DefaultDriversLicensePhotoPath)
        );

        return Convert.ToInt32(table.Rows[0]["drivers_license_id"]);
    }

    // ----------------------------
    // READ
    // ----------------------------
    public DriversLicense GetById(int licenseId)
    {
        var table = DB.Query(
            "CALL sp_drivers_licenses_get_by_id(@id);",
            ("@id", licenseId)
        );

        if (table.Rows.Count == 0)
            throw new InvalidOperationException("Drivers license not found.");

        return Map(table.Rows[0]);
    }

    public DriversLicense? GetByNumber(string licenseNumber)
    {
        var table = DB.Query(
            "CALL sp_drivers_licenses_get_by_number(@number);",
            ("@number", licenseNumber)
        );

        if (table.Rows.Count == 0)
            return null;

        return Map(table.Rows[0]);
    }

    // ----------------------------
    // UPDATE
    // ----------------------------
    public void Update(
        int licenseId,
        DateTime issueDate,
        DateTime expiryDate,
        string issuingCountry
    )
    {
        DB.Execute(
            "CALL sp_drivers_licenses_update(@id, @issue, @expiry, @country);",
            ("@id", licenseId),
            ("@issue", issueDate),
            ("@expiry", expiryDate),
            ("@country", issuingCountry)
        );
    }

    // ----------------------------
    // DELETE
    // ----------------------------
    public void Delete(int licenseId)
    {
        DB.Execute(
            "CALL sp_drivers_licenses_delete(@id);",
            ("@id", licenseId)
        );
    }

    // ----------------------------
    // PHOTO (DB ONLY)
    // ----------------------------
    public void SetFrontPhoto(int licenseId, string photoPath)
    {
        DB.Execute(
            "CALL sp_drivers_licenses_set_front_photo(@id, @path);",
            ("@id", licenseId),
            ("@path", photoPath)
        );
    }

    public void SetBackPhoto(int licenseId, string photoPath)
    {
        DB.Execute(
            "CALL sp_drivers_licenses_set_back_photo(@id, @path);",
            ("@id", licenseId),
            ("@path", photoPath)
        );
    }

    public void ResetPhotos(int licenseId)
    {
        DB.Execute(
            "CALL sp_drivers_licenses_reset_photos(@id);",
            ("@id", licenseId)
        );
    }

    // ----------------------------
    // MAPPING
    // ----------------------------
    private static DriversLicense Map(DataRow row)
    {
        string Resolve(object value) =>
            value == DBNull.Value || string.IsNullOrWhiteSpace(value.ToString())
                ? DefaultDriversLicensePhotoPath
                : value.ToString()!;

        return new DriversLicense
        {
            Id = Convert.ToInt32(row["id"]),
            LicenseNumber = row["license_number"].ToString()!,
            IssueDate = Convert.ToDateTime(row["issue_date"]),
            ExpiryDate = Convert.ToDateTime(row["expiry_date"]),
            IssuingCountry = row["issuing_country"].ToString()!,
            FrontPhotoPath = Resolve(row["front_photo_path"]),
            BackPhotoPath  = Resolve(row["back_photo_path"])
        };
    }
}
