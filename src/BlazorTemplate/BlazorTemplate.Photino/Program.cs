using BlazorTemplate.Photino.Services;
using BlazorTemplate.Rcl;
using BlazorTemplate.Shared;
using Microsoft.Extensions.DependencyInjection;
using Photino.Blazor;

internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);

        appBuilder.RootComponents.Add<App>("#app");
        appBuilder.Services.AddMasaBlazor();
        appBuilder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

        var app = appBuilder.Build();

        app.MainWindow
            .SetTitle("Photino Blazor Sample");

        AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
        {
        };

        app.Run();
    }
}