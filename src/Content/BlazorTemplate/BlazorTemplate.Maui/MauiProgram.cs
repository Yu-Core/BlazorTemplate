using BlazorTemplate.Maui.Extensions;
using Microsoft.Extensions.Logging;

namespace BlazorTemplate.Maui
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
//-:cnd:noEmit
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif
//+:cnd:noEmit
            builder.Services.AddMasaBlazor();

            builder.Services.AddDependencyInjection();

            return builder.Build();
        }
    }
}