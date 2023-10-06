using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string ProductCategory { get; set; } = string.Empty;
        [Range(0, double.MaxValue)]
        public double ProductPrice { get; set; }
    }
}
