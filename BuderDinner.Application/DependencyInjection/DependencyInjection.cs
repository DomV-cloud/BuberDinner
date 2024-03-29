﻿using BuberDinner.Infrastructure.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
