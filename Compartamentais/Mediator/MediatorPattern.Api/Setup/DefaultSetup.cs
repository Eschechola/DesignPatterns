using MediatorPattern.Data.Default.Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace MediatorPattern.Api.Setup
{
    public static class DefaultSetup
    {
        public static IServiceCollection AddMediatorDefault(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            return services;
        }
    }
}
