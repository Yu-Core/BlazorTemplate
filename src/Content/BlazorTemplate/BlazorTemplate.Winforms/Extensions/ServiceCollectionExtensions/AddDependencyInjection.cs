using BlazorTemplate.Rcl.IService;
using BlazorTemplate.Winforms.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Winforms.Extensions
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
