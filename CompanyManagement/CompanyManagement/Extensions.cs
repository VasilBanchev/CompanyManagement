using Shared.Config;

namespace CompanyManagement;

public static class Extensions
{
    public static void AddExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<DataBaseOptions>(builder.Configuration.GetSection(DataBaseOptions.DataBase));
    }
}