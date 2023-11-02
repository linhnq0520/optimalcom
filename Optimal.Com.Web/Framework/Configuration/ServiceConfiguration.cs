using Optimal.Com.Web.Framework.Entity;
using Optimal.Com.Web.Framework.Services;
using Optimal.Com.Web.Framework.Services.Interface;
using Optimal.Com.Web.Services;

namespace Optimal.Com.Web.Framework.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IJwtTokenService, JwtTokenService>();

            return services;
        }
    }
}
