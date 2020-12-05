using MediatR;
using MediatorPattern.Data.MediatR.Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace MediatorPattern.Api.Setup
{
    public static class MediatRSetup
    {
        public static IServiceCollection AddMediatorMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(MediatorHandler));

            return services;
        }
    }
}
