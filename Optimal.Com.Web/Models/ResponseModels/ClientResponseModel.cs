using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Models
{
    public class ClientResponseModel:BaseModel
    {
        [JsonProperty("client_name")]
        public string ClientName { get; set; } = string.Empty;
        [JsonProperty("date_of_birth")]
        public DateTime DayOfBirth { get; set; }
    }
}
