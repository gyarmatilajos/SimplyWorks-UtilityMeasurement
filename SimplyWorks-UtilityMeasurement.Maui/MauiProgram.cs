using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SimplyWorks_UtilityMeasurement.Maui.Data;
using SimplyWorks_UtilityMeasurement.Maui.Services;

namespace SimplyWorks_UtilityMeasurement.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "utilitymeasurement.db");

            builder.Services.AddDbContext<UtilityMeasurementDbContext>(opt =>
                opt.UseSqlite($"Data Source={dbPath}"));

            builder.Services.AddSingleton<DbInitializer>();

            // Services
            

            // VM
            

            // Views
            

            return builder.Build();
        }
    }
}
