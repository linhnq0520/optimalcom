namespace Optimal.Com.Web.Framework.Services.Interface
{
    public interface ISettingService
    {
        Task<ISetting> LoadSetting(Type type);
    }
}
