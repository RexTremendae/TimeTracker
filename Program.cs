using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker;

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
