using BlazorTemplate.Gtk;
using BlazorTemplate.Gtk.Extensions;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddGtkBlazorWebView();
#if DEBUG
services.AddBlazorWebViewDeveloperTools();
#endif

services.AddMasaBlazor();
services.AddDependencyInjection();

var sp = services.BuildServiceProvider();

var app = new App(sp);
return app.Run(args);