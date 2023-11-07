using Optimal.Com.Web.Framework.Entity;

namespace Optimal.Com.Web.Framework.Services.Interface
{
    public interface IJwtTokenService
    {
        string GetNewJwtToken(User user, long expireSeconds = 0L);
    }
}
