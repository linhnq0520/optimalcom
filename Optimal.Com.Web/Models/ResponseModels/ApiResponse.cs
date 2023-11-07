using Optimal.Com.Web.Framework.Commons;

namespace Optimal.Com.Web.Models.ResponseModels
{
    public class ApiResponse:BaseModel
    {
        public ApiResponse() { }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
