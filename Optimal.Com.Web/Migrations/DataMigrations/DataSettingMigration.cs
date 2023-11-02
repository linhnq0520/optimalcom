using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Entity;
using Optimal.Com.Web.Framework.Migration;

namespace Optimal.Com.Web.Migrations.DataMigrations
{
    public class DataSettingMigration : IEntitySeed
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData
                (
                    new Setting { Name = "AuthSetting.SecretKey", Value= "uevfqmvekswfzycptlhuhsazjzancgvz" }
                );
        }
    }
}
