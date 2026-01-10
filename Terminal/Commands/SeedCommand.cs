using Microsoft.Extensions.DependencyInjection;
using VRMS.Database.Seeders;
using VRMS.Services.Account;

namespace VRMS.Terminal.Commands;

public class SeedCommand : ICommand
{
    public string Name => "seed";

    public CommandResult Execute(string[] args)
    {
        try
        {
            var services = new ServiceCollection();

            // Register the services here first
            services.AddSingleton<UserService>();

            var provider = services.BuildServiceProvider();

            SeederRunner.RunAll(provider);

            return new CommandResult(
                true,
                "Database seeded successfully."
            );
        }
        catch (Exception ex)
        {
            return new CommandResult(
                false,
                $"Seeding failed:\n{ex.Message}"
            );
        }
    }
}