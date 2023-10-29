using BlazorTemplate.Photino.Services;
using BlazorTemplate.Rcl.IService;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Photino.Extensions
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
