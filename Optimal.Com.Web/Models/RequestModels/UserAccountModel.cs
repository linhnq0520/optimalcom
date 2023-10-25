using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Models.RequestModels
{
    public class UserAccountModel:BaseModel
    {
        public UserAccountModel() { }

        [JsonProperty("User_id")]
        public string UserId { get; set; } = string.Empty;

        [JsonProperty("User_name")]
        public string UserName { get; set; } = string.Empty;

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
        [JsonProperty("position")]
        public string Posision { get; set; } = string.Empty;
    }
    public class UserUpdateModel : BaseModel
    {
        public UserUpdateModel() { }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("User_id")]
        public string UserId { get; set; } = string.Empty;

        [JsonProperty("User_name")]
        public string UserName { get; set; } = string.Empty;

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
        [JsonProperty("position")]
        public string Posision { get; set; } = string.Empty;
    }
}
