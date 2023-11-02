using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Extensions;

namespace Optimal.Com.Web.Data.Builders
{
    public class CodelistBuilder : IEntityTypeConfiguration<Codelist>
    {
        public void Configure(EntityTypeBuilder<Codelist> builder)
        {
            builder.Property(s => s.CodeGroup).IsRequired().AsString(10);
            builder.Property(s=>s.CodeName).IsRequired().AsString(10);
            builder.Property(s=>s.CodeId).IsRequired().AsString(10);
            builder.Property(s=>s.Caption).IsRequired().AsString(100);

        }
    }
}
