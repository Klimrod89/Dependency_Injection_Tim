﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace BlazorServerDemo;

public static class DemoDISetup
{
    public static IServiceCollection AddDemoInfo(this IServiceCollection services)
    {
        services.AddTransient<IDemo, Demo>();
        services.AddTransient<IDemo, UtcDemo>();
        services.AddTransient<ProcessDemo>();
        return services;
    }
}
