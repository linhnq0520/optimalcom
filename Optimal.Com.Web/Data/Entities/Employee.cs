using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    public class Employee:BaseEntity
    {
        public string EmployeeID { get; set; } = string.Empty; 
        public string EmployeeName { get; set;} = string.Empty;
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BranchCode { get; set; }=string.Empty;
        public string Status { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
