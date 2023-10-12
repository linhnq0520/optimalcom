using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Data.Builders
{
    public class CustomerBuilder : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(s => s.CustomerID).IsRequired().AsString(10);
            builder.HasKey(s => s.CustomerID);
            builder.HasIndex(s => s.CustomerID);
            builder.Property(s=>s.CustomerName).IsRequired().AsString(50);
        }
    }
}
