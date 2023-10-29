using BlazorTemplate.Rcl.IService;
using BlazorTemplate.Wpf.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Wpf.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddSingleton<IStaticWebAssets, StaticWebAssets>();
            return services;
        }
    }
}
