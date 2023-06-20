using BlazorTemplate.Rcl;
using BlazorTemplate.Shared;
using BlazorTemplate.Winforms.Services;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Winforms
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddMasaBlazor();
            services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

            blazorWebView1.HostPage = "wwwroot/index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Environment.Exit(0);
        }
    }
}