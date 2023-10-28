using BlazorTemplate.Shared;
using BlazorTemplate.WebAssembly.Services;

namespace BlazorTemplate.WebAssembly.Extensions
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
