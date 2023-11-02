using Optimal.Com.Web.Framework.Commons;

namespace Optimal.Com.Web.Data.Entities
{
    public class Codelist:BaseEntity
    {
        public string CodeGroup { get; set; } = string.Empty;
        public string CodeName { get; set;} = string.Empty;
        public string CodeId { get; set;} = string.Empty;
        public string Caption { get; set; } = string.Empty;

    }
}
