using FluentMigrator;
using FluentMigrator.Runner;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Optimal.Com.Web.Framework.Repository;
using Optimal.Com.Web.Services;
using System.Reflection;

namespace Optimal.Com.Web.Startup
{
    public static class MigrationConfiguration
    {
        public static IServiceCollection AddFulentMigratorService(this IServiceCollection services, IConfiguration configuration)
        {
            var serviceProvider = services.BuildServiceProvider();

            var migrationTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.GetCustomAttributes<MigrationAttribute>().Any())
                .ToList();

            foreach (var migrationType in migrationTypes)
            {
                services.AddFluentMigratorCore()
                    .ConfigureRunner(builder => builder
                        .AddSqlServer()
                        .WithGlobalConnectionString(configuration.GetConnectionString("ConnectionString"))
                        .ScanIn(migrationType.Assembly).For.Migrations());
            }
            //var migrationAssembly = Assembly.GetEntryAssembly();

            //services.AddFluentMigratorCore()
            //.ConfigureRunner(builder => builder
            //    .AddSqlServer()
            //.WithGlobalConnectionString(configuration.GetConnectionString("ConnectionString"))
            //    .ScanIn(migrationAssembly).For.Migrations());

            // Lấy assembly chứa migration classes
            //var migrationAssembly = Assembly.GetEntryAssembly(); // Hoặc sử dụng Assembly.GetCallingAssembly() tùy vào cấu trúc dự án của bạn

            //// Khởi tạo MigrationRunner
            //var serviceProvider = services.BuildServiceProvider();
            //using (var scope = serviceProvider.CreateScope())
            //{
            //    var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
            //    runner.ListMigrations();
            //    runner.MigrateUp();
            //}

            return services;
        }
    }
}
