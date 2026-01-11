using Microsoft.Extensions.DependencyInjection;
using VRMS.Repositories.Accounts;
using VRMS.Repositories.Customers;
using VRMS.Repositories.Fleet;
using VRMS.Services.Account;
using VRMS.Services.Customer;
using VRMS.Services.Fleet;

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

        // Fleet 
        services.AddSingleton<VehicleRepository>();
        services.AddSingleton<VehicleCategoryRepository>();
        services.AddSingleton<VehicleFeatureRepository>();
        services.AddSingleton<VehicleFeatureMappingRepository>();
        services.AddSingleton<VehicleImageRepository>();
        services.AddSingleton<MaintenanceRepository>();
        
        // Customers
        services.AddSingleton<CustomerRepository>();
        services.AddSingleton<DriversLicenseRepository>();

        // ----------------------------
        // SERVICES
        // ----------------------------
        services.AddSingleton<UserService>();
        services.AddSingleton<VehicleService>();
        services.AddSingleton<CustomerService>();
        services.AddSingleton<DriversLicenseService>();
    }
}