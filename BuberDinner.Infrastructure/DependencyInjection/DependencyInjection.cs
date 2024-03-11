using BuberDinner.Infrastructure.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
