﻿using BlazorTemplate.Wpf.Services;
using BlazorTemplate.Shared;
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