using Newtonsoft.Json;
using Optimal.Com.Web.Framework.Commons;

namespace OptimalCom.Web.Models
{
    public class ClientModel:BaseModel
    {
        public ClientModel() { }

        [JsonProperty("client_name")]
        public string ClientName { get; set; } = string.Empty;
        [JsonProperty("date_of_birth")]
        public DateTime DayOfBirth { get; set; }
    }
}
