using BlazorTemplate.Rcl.IService;
using BlazorTemplate.Server.Services;

namespace BlazorTemplate.Server.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IStaticWebAssets, StaticWebAssets>();
            return services;
        }
    }
}
