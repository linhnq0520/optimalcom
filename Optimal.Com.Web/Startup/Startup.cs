using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Common;
using Optimal.Com.Web.Framework.Data;
using Optimal.Com.Web.Framework.Infrastructure;
using Optimal.Com.Web.Framework.Interface;
using Optimal.Com.Web.Framework.Service;
using Optimal.Com.Web.Services;
using Optimal.Com.Web.Startup.Mapper;

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
            // Services
            builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            builder.Services.AddScoped<IUserAccountService, UserAccountService>();
            builder.Services.AddScoped<ISettingService, SettingService>();
            var settings = AppDomainInfrastructure.FindClassesOfType<ISetting>().ToList();
            foreach(var setting in settings)
            {
                builder.Services.AddTransient(setting, context =>
                {
                    return context.GetRequiredService<ISettingService>().LoadSetting(setting).Result;
                });
            }    
           
        }
    }
}
