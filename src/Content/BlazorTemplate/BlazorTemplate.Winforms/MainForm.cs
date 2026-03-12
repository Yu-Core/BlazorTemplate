using BlazorTemplate.Rcl;
using BlazorTemplate.Winforms.Extensions;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif
            services.AddMasaBlazor();
            services.AddDependencyInjection();

            blazorWebView1.HostPage = "wwwroot/index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Routes>("#app");
        }

        //Fix resource not released after closing app
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Environment.Exit(0);
        }
    }
}