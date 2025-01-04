using Microsoft.Extensions.Logging;
using Blazored.LocalStorage;



namespace ExpenseTrackerApp
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

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            // Configure DatabaseService
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyDatabase1.db");

            builder.Services.AddSingleton(new DatabaseService(dbPath));

            builder.Services.AddBlazoredLocalStorage();  // Add LocalStorage support
           



            return builder.Build();
        }
    }
}
