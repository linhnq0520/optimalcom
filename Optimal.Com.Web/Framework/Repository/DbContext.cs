using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Framework.Extensions;

namespace Optimal.Com.Web.Framework.Repository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
            modelBuilder.ApplySeedDataFromCurrentAssembly();
        }
    }
}
