using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker;

public static class Program
{
    public static void Main()
    {
        new HostBuilder()
        .ConfigureServices((hostContext, services) =>
        {
            services.AddSqlServer<TimeTrackerDbContext>(
                "Data Source=.;" +
                "Database=TimeTracker;" +
                "User Id=sa;" +
                "Password=VerySecret123!;"
            );
        })
        .Build()
        .Run();
    }
}