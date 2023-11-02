using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Optimal.Com.Web.Framework.Commons
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseModel
    {
    }

}
