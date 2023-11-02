using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Optimal.Com.Web.Common;
using Optimal.Com.Web.Framework.Configuration;
using Optimal.Com.Web.Framework.Infrastructure;
using Optimal.Com.Web.Framework.Repository;
using Optimal.Com.Web.Startup.Mapper;
using System.Text;

namespace Optimal.Com.Web.Startup
{
    public static class StartupConfiguration
    {
        public static void ConfigureServices(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Configuration.AddJsonFile("appsettings.json");
            builder.Services.AddDbContext<MyDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
            });
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = new SnakeCaseNamingPolicy();
            }); ;
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApplicationServices();
            builder.Services.AddSettingService();
            builder.Services.AddAuthenticationService(configuration);
        }

    }
}
