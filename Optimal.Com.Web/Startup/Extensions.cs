using Optimal.Com.Web.Framework.Infrastructure;
using Optimal.Com.Web.Framework.Repository;
using Optimal.Com.Web.Framework.Services;
using Optimal.Com.Web.Framework.Services.Interface;
using Optimal.Com.Web.Services;

namespace Optimal.Com.Web.Startup
{
    public static class Extensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Services
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserAccountService, UserAccountService>();

            return services;
        }
        public static IServiceCollection AddSettingService(this IServiceCollection services)
        {
            services.AddScoped<ISettingService, SettingService>();
            var settings = AppDomainInfrastructure.FindClassesOfType<ISetting>().ToList();
            foreach (var setting in settings)
            {
                services.AddTransient(setting, context =>
                {
                    return context.GetRequiredService<ISettingService>().LoadSetting(setting).Result;
                });
            }
            return services;
        }
    }
}
