using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Data.Builders
{
    public class EmailConfigBuilder : IEntityTypeConfiguration<EmailConfig>
    {
        public void Configure(EntityTypeBuilder<EmailConfig> builder)
        {
            builder.Property(s => s.ConfigId).IsRequired().AsString(10);
            builder.HasKey(s => s.ConfigId);
            builder.Property(s=>s.Host).IsRequired().AsString(50);
            builder.Property(s => s.Port).IsRequired().HasMaxLength(5);
            builder.Property(s => s.Sender).IsRequired().AsString(50);
            builder.Property(s=>s.Password).IsRequired().AsString(100);
            builder.Property(s => s.EnableTLS).IsRequired();
        }
    }
}
