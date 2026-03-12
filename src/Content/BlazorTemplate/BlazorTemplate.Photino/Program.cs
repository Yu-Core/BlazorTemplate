using BlazorTemplate.Photino.Extensions;
using BlazorTemplate.Rcl;
using Microsoft.Extensions.DependencyInjection;
using Photino.Blazor;

internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);

        appBuilder.RootComponents.Add<Routes>("#app");
        appBuilder.Services.AddMasaBlazor();
        appBuilder.Services.AddDependencyInjection();

        var app = appBuilder.Build();

        app.MainWindow
            .SetTitle("BlazorTemplate.Photino");

        AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
        {
        };

        app.Run();
    }
}