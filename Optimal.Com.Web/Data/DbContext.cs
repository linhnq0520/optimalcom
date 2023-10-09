using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework;
using System.Reflection;

namespace Optimal.Com.Web.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();
        }
    }
}
