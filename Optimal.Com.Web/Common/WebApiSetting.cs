using Optimal.Com.Web.Framework.Services.Interface;

namespace Optimal.Com.Web.Common
{
    public class WebApiSetting:ISetting
    {
        public WebApiSetting() { }
        public string SecretKey { get; set; }
        public int TokenLifetimeDays { get; set; } = 7;
    }
}
