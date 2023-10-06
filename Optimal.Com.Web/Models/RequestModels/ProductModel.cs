using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Models.RequestModels
{
    public class ProductModel:BaseModel
    {
        public ProductModel() { }
        [JsonProperty("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonProperty("product_name")]
        public string ProductName { get; set; } = string.Empty;

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; } = string.Empty;

        [JsonProperty("product_type")]
        public string ProductType { get; set; } = string.Empty;

        [JsonProperty("product_category")]
        public string ProductCategory { get; set; } = string.Empty;

        [JsonProperty("product_price")]
        public double ProductPrice { get; set; }
    }
}
