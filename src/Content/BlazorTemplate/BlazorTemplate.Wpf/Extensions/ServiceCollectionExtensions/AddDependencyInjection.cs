using BlazorTemplate.Rcl.Service;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Wpf.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddSingleton<IStaticWebAssets, Services.StaticWebAssets>();
            return services;
        }
    }
}
