using Microsoft.Extensions.DependencyInjection;
using VRMS.Repositories.Accounts;
using VRMS.Repositories.Fleet;
using VRMS.Services.Account;
using VRMS.Services.Fleet;

namespace VRMS.Database.Seeders;

public static class SeederServiceRegistry
{
    public static void Register(IServiceCollection services)
    {
        // ----------------------------
        // REPOSITORIES
        // ----------------------------
        services.AddSingleton<UserRepository>();

        // Fleet (example – add others as needed)
        services.AddSingleton<VehicleRepository>();
        services.AddSingleton<VehicleCategoryRepository>();
        services.AddSingleton<VehicleFeatureRepository>();
        services.AddSingleton<VehicleFeatureMappingRepository>();
        services.AddSingleton<VehicleImageRepository>();
        services.AddSingleton<MaintenanceRepository>();

        // ----------------------------
        // SERVICES
        // ----------------------------
        services.AddSingleton<UserService>();
        services.AddSingleton<VehicleService>();
    }
}