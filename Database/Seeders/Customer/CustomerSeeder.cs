using System;
using System.IO;
using System.Linq;
using VRMS.Enums;
using VRMS.Services.Customer;

namespace VRMS.Database.Seeders.Customer;

public class CustomerSeeder : ISeeder
{
    public string Name => nameof(CustomerSeeder);

    private readonly CustomerService _customerService;
    private readonly DriversLicenseService _licenseService;

    public CustomerSeeder(
        CustomerService customerService,
        DriversLicenseService licenseService)
    {
        _customerService = customerService;
        _licenseService  = licenseService;
    }

    public void Run()
    {
        // -------------------------------------------------
        // DRIVER LICENSES
        // -------------------------------------------------

        var licenseLee = EnsureLicense(
            licenseNumber: "DL-PH-0001",
            issueDate: new DateTime(2018, 5, 1),
            expiryDate: new DateTime(2028, 12, 31)
        );

        var licenseDustin = EnsureLicense(
            licenseNumber: "DL-PH-0002",
            issueDate: new DateTime(2019, 6, 15),
            expiryDate: new DateTime(2027, 6, 30)
        );

        var licenseChael = EnsureLicense(
            licenseNumber: "DL-PH-0100",
            issueDate: new DateTime(2020, 1, 1),
            expiryDate: new DateTime(2030, 1, 1)
        );
        
        var licenseCorp = EnsureLicense(
            licenseNumber: "DL-PH-0003",
            issueDate: new DateTime(2026, 11, 15),
            expiryDate: new DateTime(2027, 6, 30)
        );


        // -------------------------------------------------
        // CUSTOMERS
        // -------------------------------------------------

        SeedCustomer(
            firstName: "Lee",
            lastName: "Singson",
            email: "leesingeon@email.com",
            phone: "09171234567",
            address: "Quezon City, Metro Manila",
            dob: new DateTime(1992, 4, 12),
            category: CustomerCategory.Individual,
            frequent: true,
            blacklisted: false,
            licenseId: licenseLee,
            photoFileName: "lee.jpg"
        );

        SeedCustomer(
            firstName: "Dustin",
            lastName: "Angway",
            email: "dustin.angway@email.com",
            phone: "09179876543",
            address: "Cebu City, Cebu",
            dob: new DateTime(1995, 9, 3),
            category: CustomerCategory.Individual,
            frequent: true,
            blacklisted: false,
            licenseId: licenseDustin,
            photoFileName: "dustin.jpg"
        );
        
        SeedCustomer(
            firstName: "Chael",
            lastName: "Lusaya",
            email: "chael@gmail.com",
            phone: "02812345671",
            address: "Makati City, Metro Manila",
            dob: new DateTime(2005, 1, 1), // incorporation date
            category: CustomerCategory.Corporate,
            frequent: true,
            blacklisted: false,
            licenseId: licenseChael,
            photoFileName: "chael.jpg"
        );

        SeedCustomer(
            firstName: "ACME",
            lastName: "Logistics Inc.",
            email: "fleet@acmelogistics.com",
            phone: "0281234567",
            address: "Makati City, Metro Manila",
            dob: new DateTime(2005, 1, 1), // incorporation date
            category: CustomerCategory.Corporate,
            frequent: true,
            blacklisted: false,
            licenseId: licenseCorp,
            photoFileName: "acme.jpg"
        );
    }

    // -------------------------------------------------
    // HELPERS
    // -------------------------------------------------

    private int EnsureLicense(
        string licenseNumber,
        DateTime issueDate,
        DateTime expiryDate,
        string issuingCountry = "PH"
    )
    {
        var existing =
            _licenseService.GetDriversLicenseByNumber(licenseNumber);

        return existing?.Id
               ?? _licenseService.CreateDriversLicense(
                   licenseNumber,
                   issueDate,
                   expiryDate,
                   issuingCountry
               );
    }

    private void SeedCustomer(
        string firstName,
        string lastName,
        string email,
        string phone,
        string address,
        DateTime dob,
        CustomerCategory category,
        bool frequent,
        bool blacklisted,
        int licenseId,
        string? photoFileName)
    {
        var existing = _customerService
            .GetAllCustomers()
            .FirstOrDefault(c =>
                c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        var customerId = existing?.Id
                         ?? _customerService.CreateCustomer(
                                firstName,
                                lastName,
                                email,
                                phone,
                                address,
                                dob,
                                category,
                                frequent,
                                blacklisted,
                                licenseId
                            );

        if (!string.IsNullOrWhiteSpace(photoFileName))
            AddPhotoIfExists(customerId, photoFileName);
    }

    private static string GetImageBasePath()
    {
        return Path.Combine(
            AppContext.BaseDirectory,
            "Assets",
            "Seed",
            "Customers"
        );
    }

    private void AddPhotoIfExists(
        int customerId,
        string imageFileName)
    {
        var fullPath = Path.Combine(
            GetImageBasePath(),
            imageFileName
        );

        if (!File.Exists(fullPath))
        {
            Console.WriteLine(
                $"      [WARN] Customer image not found: {imageFileName}");
            return;
        }

        using var stream = File.OpenRead(fullPath);

        _customerService.SetCustomerPhoto(
            customerId,
            stream,
            imageFileName
        );

        Console.WriteLine(
            $"      Seeded customer photo: {imageFileName}");
    }
}
