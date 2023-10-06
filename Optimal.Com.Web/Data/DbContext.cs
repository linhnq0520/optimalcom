using Microsoft.EntityFrameworkCore;
using Optimal.Com.Web.Data.Entities;

namespace Optimal.Com.Web.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>(e =>
            {
                e.ToTable("ProductType");
                e.HasKey(t => t.TypeCode);
            });
        }
    }
}
