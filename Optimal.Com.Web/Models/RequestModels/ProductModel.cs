using System.ComponentModel.DataAnnotations;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Models.RequestModels
{
    public class ProductModel:BaseModel
    {
        public ProductModel() { }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductType { get; set; } = string.Empty;
        public string ProductCategory { get; set; } = string.Empty;
        public double ProductPrice { get; set; }
    }
}
