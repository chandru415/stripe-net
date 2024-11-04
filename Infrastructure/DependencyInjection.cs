using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IIdentityService, IdentityService>();
            return services;
        }
    }
}
