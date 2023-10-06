using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    public class Branch:BaseEntity
    {
        public string BranchCode { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
    }
}
