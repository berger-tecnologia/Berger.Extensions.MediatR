using Microsoft.Extensions.DependencyInjection;

namespace Berger.Extensions.Mediator
{
    public static class MediatorConfiguration
    {
        public static IServiceCollection ConfigureMediator(this IServiceCollection services, string package)
        {
            var assembly = AppDomain.CurrentDomain.Load(package);

            return services.AddMediatR(config => config.RegisterServicesFromAssemblies(assembly));
        }
    }
}