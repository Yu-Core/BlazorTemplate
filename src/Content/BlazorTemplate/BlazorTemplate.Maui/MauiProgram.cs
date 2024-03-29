﻿using BlazorTemplate.Maui.Extensions;
using BlazorTemplate.Maui.Services;
using BlazorTemplate.Shared;
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
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddMasaBlazor();

            builder.Services.AddDependencyInjection();

            return builder.Build();
        }
    }
}