using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data;
using Optimal.Com.Web.Framework.Data;
using Optimal.Com.Web.Framework.Infrastructure;
using Optimal.Com.Web.Services;
using Optimal.Com.Web.Startup.Mapper;
using System.Text.Json;

namespace Optimal.Com.Web.Startup
{
    public static class StartupConfiguration
    {
        public static void ConfigureServices(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Configuration.AddJsonFile("appsettings.json");

            // Services
            builder.Services.AddDbContext<MyDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
            });
            builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = new SnakeCaseNamingPolicy();
            }); ;
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserService, UserService>();
        }
    }
}
