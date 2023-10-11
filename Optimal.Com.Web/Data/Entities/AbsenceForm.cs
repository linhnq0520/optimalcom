using Newtonsoft.Json;
using Optimal.Com.Web.Framework;

namespace Optimal.Com.Web.Data.Entities
{
    public class AbsenceForm:BaseEntity
    {
        public AbsenceForm() { }
        public string UserId { get; set; } = string.Empty;
        public DateTime AbsenceFromDate { get; set; }
        public DateTime AbsenceToDate { get; set; }
        public int TotalAbsenceDay { get; set; }
        public string ReasonAbsence { get; set; } = string.Empty;
        public string Status = string.Empty;
        public string AbsenceType {  get; set; } = string.Empty;
        public string PersonApprove { get; set; } = string.Empty;
        public DateTime ApproveDate { get; set; }
    }
}
