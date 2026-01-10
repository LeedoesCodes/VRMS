using Microsoft.Extensions.DependencyInjection;
using VRMS.Database.Seeders.Users;
using VRMS.Services.Account;

namespace VRMS.Database.Seeders;

public static class SeederRunner
{
    public static void RunAll(IServiceProvider services)
    {
        var seeders = new ISeeder[]
        {
            new UserSeeder(
                services.GetRequiredService<UserService>()
            ),

            // later:
            // new VehicleSeeder(...)
            // new RateSeeder(...)
        };

        foreach (var seeder in seeders)
            seeder.Run();
    }
}