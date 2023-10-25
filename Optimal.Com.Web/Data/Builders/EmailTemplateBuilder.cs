using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Data.Builders
{
    public class EmailTemplateBuilder : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.Property(s => s.TemplateId).IsRequired().AsString(50);
            builder.HasKey(s => s.TemplateId);
            builder.Property(s=>s.Status).IsRequired().AsString(10);
            builder.Property(s => s.Description).AsString(500).IsRequired(false);
            builder.Property(s => s.Subject).AsString(500).IsRequired();
            builder.Property(s => s.Body).IsRequired();
            builder.Property(s => s.Attachments).IsRequired(false);
        }
    }
}
