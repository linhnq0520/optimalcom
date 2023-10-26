using Optimal.Com.Web.Framework.Interface;

namespace Optimal.Com.Web.Framework.Service
{
    public interface ISettingService
    {
        Task<ISetting> LoadSetting(Type type);
    }
}
