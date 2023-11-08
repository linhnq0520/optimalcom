using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Entity;
using Optimal.Com.Web.Framework.MigrationExtensions;

namespace Optimal.Com.Web.Migrations.DataMigrations
{
    public class DataSettingMigration : IEntitySeed
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData
                (
                    new Setting { Name = "WebApiSetting.SecretKey", Value= "lNMJ8FzDjL15jalPwAXcR3RV46EQsO5N" }
                );
        }
    }
}
