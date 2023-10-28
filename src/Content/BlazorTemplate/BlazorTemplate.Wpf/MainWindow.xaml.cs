using BlazorTemplate.Wpf.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazorTemplate.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
#if DEBUG
            serviceCollection.AddBlazorWebViewDeveloperTools();
#endif
            serviceCollection.AddMasaBlazor();
            serviceCollection.AddDependencyInjection();

            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}