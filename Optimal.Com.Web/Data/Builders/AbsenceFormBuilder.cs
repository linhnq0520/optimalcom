using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework.Migrations;

namespace Optimal.Com.Web.Data.Builders
{
    public class AbsenceFormBuilder : IEntityTypeConfiguration<AbsenceForm>
    {
        public void Configure(EntityTypeBuilder<AbsenceForm> builder)
        {
            builder.Property(s => s.AbsenceFormCode).IsRequired().AsString(10);
            builder.Property(s => s.UserId).IsRequired().AsString(10);
            builder.Property(s => s.AbsenceFromDate).IsRequired();
            builder.Property(s=>s.AbsenceToDate).IsRequired();
            builder.Property(s=>s.TotalAbsenceDay).IsRequired().HasMaxLength(2);
            builder.Property(s=>s.ReasonAbsence).IsRequired().AsString(500);
            builder.Property(s=>s.Status).IsRequired().AsString(1);
            builder.Property(s=>s.AbsenceType).IsRequired().AsString(10);
            builder.Property(s=>s.PersonApprove).AsString(10);
            builder.Property(s => s.ApproveDate);
        }
    }
}
