using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
        }
    }
}
