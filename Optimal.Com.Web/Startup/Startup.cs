﻿using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data;
using Optimal.Com.Web.Framework.Data;
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
            builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            builder.Services.AddControllers();
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => c.DescribeAllParametersInCamelCase());
        }
    }
}
