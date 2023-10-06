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
    }
}
