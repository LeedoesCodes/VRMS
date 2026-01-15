using Microsoft.Extensions.DependencyInjection;
using VRMS.Repositories.Accounts;
using VRMS.Repositories.Billing;
using VRMS.Repositories.Customers;
using VRMS.Repositories.Damages;
using VRMS.Repositories.Fleet;
using VRMS.Repositories.Inspections;
using VRMS.Repositories.Rentals;
using VRMS.Services.Account;
using VRMS.Services.Billing;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;
using VRMS.Services.Rental;

namespace VRMS.Database.Seeders;

public static class ServiceRepositoryRegistry
{
    public static void Register(IServiceCollection services)
    {
        // ----------------------------
        // REPOSITORIES
        // ----------------------------

        // Accounts
        services.AddSingleton<UserRepository>();
        services.AddSingleton<CustomerAccountRepository>();

        // Fleet
        services.AddSingleton<VehicleRepository>();
        services.AddSingleton<VehicleCategoryRepository>();
        services.AddSingleton<VehicleFeatureRepository>();
        services.AddSingleton<VehicleFeatureMappingRepository>();
        services.AddSingleton<VehicleImageRepository>();
        services.AddSingleton<MaintenanceRepository>();
        services.AddSingleton<VehicleInspectionRepository>();

        // Customers
        services.AddSingleton<CustomerRepository>();
        services.AddSingleton<DriversLicenseRepository>();

        // Billing
        services.AddSingleton<InvoiceRepository>();
        services.AddSingleton<InvoiceLineItemRepository>();
        services.AddSingleton<PaymentRepository>();
        services.AddSingleton<RateConfigurationRepository>();
        
        // Rentals
        services.AddSingleton<RentalRepository>();
        
        // Damages
        services.AddSingleton<DamageRepository>();
        services.AddSingleton<DamageReportRepository>();
        

        // ----------------------------
        // SERVICES
        // ----------------------------

        services.AddSingleton<UserService>();
        services.AddSingleton<CustomerAccountService>();
        services.AddSingleton<DriversLicenseService>();
        services.AddSingleton<CustomerService>();
        services.AddSingleton<VehicleService>();
        services.AddSingleton<BillingService>();
        services.AddSingleton<RentalService>();
        services.AddSingleton<RateService>();
    }
}
