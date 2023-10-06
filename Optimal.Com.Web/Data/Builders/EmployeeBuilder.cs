using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optimal.Com.Web.Data.Entities;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Builders
{
    public class EmployeeBuilder : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(s=>s.EmployeeName).IsRequired().AsString(50);
            builder.Property(s=>s.EmployeeID).IsRequired().AsString(5);
            builder.HasIndex(s => s.EmployeeID);
            builder.HasKey(s => s.EmployeeID);
            builder.Property(s=>s.DateOfBirth).IsRequired();
            builder.Property(s=>s.BranchCode).IsRequired().AsString(5);
            builder.Property(s=>s.Gender).IsRequired().HasMaxLength(1);
            builder.Property(s=>s.PhoneNumber).AsString(10);
            builder.Property(s=>s.Address).IsRequired().AsString(100);
            builder.Property(s=>s.Email).AsString(50);
            builder.Property(s=>s.RemainingDaysOff).HasMaxLength(2);
            builder.Property(s=>s.DaysOffUsed).HasMaxLength(2);
        }
    }
}
