using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Framework.Entity.Builder
{
    public class SettingBuilder : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.Property(x => x.Name).IsRequired().AsString(100);
            builder.HasKey(x => x.Name);
            builder.Property(x => x.Value).IsRequired().AsString(500);
        }
    }
}
