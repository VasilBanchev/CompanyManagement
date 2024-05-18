using Shared.Config;
using Shared.Database;

namespace CompanyManagement;

public static class Extensions
{
    public static void AddExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<DataBaseOptions>(builder.Configuration.GetSection(DataBaseOptions.DataBase));
        builder.Services.AddScoped<CompanyDbContext>();

    }
    
    public static void EnsureDatabaseCreated(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetService<CompanyDbContext>();
        db!.Database.EnsureCreated();
    }
}