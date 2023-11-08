using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Entity;
using Optimal.Com.Web.Framework.MigrationExtensions;

namespace Optimal.Com.Web.Migrations.DataMigrations
{
    public class DataSettingMigration2 : IEntitySeed
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData
                (
                    new Setting { Name = "WebApiSetting.Audience", Value= "JWTServicePostmanClient" },
                    new Setting { Name = "WebApiSetting.Issuer", Value= "JWTAuthenticationServer" },
                    new Setting { Name = "WebApiSetting.Subject", Value= "JWTServiceAccessToken" }
                );
        }
    }
}
