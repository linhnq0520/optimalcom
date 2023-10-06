using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [JsonProperty("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonProperty("product_name")]
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; } = string.Empty;

        [JsonProperty("product_description")]
        public string ProductDescription { get; set; } = string.Empty;

        [JsonProperty("product_type")]
        public string ProductType { get; set; } = string.Empty;

        [JsonProperty("product_category")]
        public string ProductCategory { get; set; } = string.Empty;

        [JsonProperty("product_price")]
        [Range(0, double.MaxValue)]
        public double ProductPrice { get; set; }
    }
}
