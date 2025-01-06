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
            //for webview services

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            // Configure DatabaseService
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyDatabase1.db");

            builder.Services.AddSingleton(new DatabaseService(dbPath));          // Path for MyDatabas1.db

            builder.Services.AddBlazoredLocalStorage();  // Local bazor for session
           



            return builder.Build();
        }
    }
}
