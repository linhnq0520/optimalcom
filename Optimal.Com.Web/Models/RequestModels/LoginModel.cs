using Optimal.Com.Web.Framework.Commons;

namespace Optimal.Com.Web.Models.RequestModels
{
    public class LoginModel:BaseModel
    {
        public LoginModel() { }
        public string LoginName {  get; set; }
        public string Password { get; set; }
    }
}
