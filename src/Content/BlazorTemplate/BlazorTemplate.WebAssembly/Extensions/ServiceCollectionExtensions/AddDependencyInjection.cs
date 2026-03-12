using BlazorTemplate.Rcl.Service;

namespace BlazorTemplate.WebAssembly.Extensions
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
