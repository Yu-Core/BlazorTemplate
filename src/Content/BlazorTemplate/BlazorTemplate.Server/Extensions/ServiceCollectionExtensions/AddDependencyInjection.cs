using BlazorTemplate.Rcl.Service;

namespace BlazorTemplate.Server.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IStaticWebAssets, Services.StaticWebAssets>();
            return services;
        }
    }
}
