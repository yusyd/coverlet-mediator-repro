using Microsoft.Extensions.DependencyInjection;

namespace Repro.Application;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediator(options =>
        {
            options.ServiceLifetime = ServiceLifetime.Scoped;
            options.Namespace = "Repro.Application";
            options.Assemblies = [typeof(ApplicationExtensions)];
        });

        return services;
    }
}
