using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    public class ProductType : BaseEntity
    {
        public string TypeCode { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
    }
}
