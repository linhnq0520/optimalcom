using Optimal.Com.Web.Framework.Interface;

namespace Optimal.Com.Web.Common
{
    public class AuthSetting:ISetting
    {
        public AuthSetting() { }
        public string SecretKey { get; set; }
    }
}
