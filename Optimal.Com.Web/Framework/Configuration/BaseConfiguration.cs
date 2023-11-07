using Optimal.Com.Web.Framework.Services;
using Optimal.Com.Web.Framework.Services.Interface;

namespace Optimal.Com.Web.Framework.Configuration
{
    public static class BaseConfiguration
    {
        public static void ConfigureServicesBase(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();
        }
    }
}
