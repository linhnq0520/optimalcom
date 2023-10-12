using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    public class Customer:BaseEntity
    {
        [JsonProperty("customer_id")]
        public string CustomerID { get; set; } = string.Empty;
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; } = string.Empty;
    }
}
