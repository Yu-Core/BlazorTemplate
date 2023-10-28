using BlazorTemplate.Shared;
using BlazorTemplate.Photino.Services;
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
