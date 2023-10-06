using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    public class Employee:BaseEntity
    {
        public string EmployeeID { get; set; } = string.Empty; 
        public string EmployeeName { get; set;} = string.Empty;

    }
}
