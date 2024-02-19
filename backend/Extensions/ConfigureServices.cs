using backend.Data;
using backend.Interfaces;
using backend.Models;
using backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;

namespace backend.Extensions
{
    public static class ConfigureServices
    {
        public static void SetupServices(IServiceCollection services)
        {
            // Register the ConfigService
            services.AddScoped<IConfigService, ConfigService>();

            // Retrieve the configuration data
            IConfigService configService = new ConfigService();
            Config configData = configService.GetConfig();

            // Build the connection string using the configuration data
            string connectionString = $"server={configData.dbHost};port=3306;database={configData.dbName};User={configData.dbUsername};Password={configData.dbPassword}";

            // Add DbContext using the constructed connection string
            services.AddDbContext<DataContext>(
                options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            );

            services.AddIdentityApiEndpoints<User>().AddEntityFrameworkStores<DataContext>();
        }
    }
}
