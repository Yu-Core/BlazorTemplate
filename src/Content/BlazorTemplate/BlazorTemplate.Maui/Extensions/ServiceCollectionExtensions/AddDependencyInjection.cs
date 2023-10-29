using BlazorTemplate.Maui.Services;
using BlazorTemplate.Rcl.IService;

namespace BlazorTemplate.Maui.Extensions
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
