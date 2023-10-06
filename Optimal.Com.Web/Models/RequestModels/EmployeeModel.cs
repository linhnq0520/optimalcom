using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Models.RequestModels
{
    public class EmployeeModel:BaseModel
    {
        public EmployeeModel() { }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; } = string.Empty;

        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; } = string.Empty;

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("branch_code")]
        public string BranchCode { get; set; } = string.Empty;

        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [JsonProperty("address")]
        public string Address { get; set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; set; } = string.Empty;
    }
    public class EmployeeUpdateModel : BaseModel
    {
        public EmployeeUpdateModel() { }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; } = string.Empty;

        [JsonProperty("employee_name")]
        public string EmployeeName { get; set; } = string.Empty;

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("branch_code")]
        public string BranchCode { get; set; } = string.Empty;

        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [JsonProperty("address")]
        public string Address { get; set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; set; } = string.Empty;
    }
}
