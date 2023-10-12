using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Data.Builders
{
    public class BranchBuilder : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.Property(s => s.BranchCode).IsRequired().AsString(10);
            builder.Property(s=>s.BranchName).IsRequired().AsString(50);
        }
    }
}
