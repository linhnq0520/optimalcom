using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Optimal.Com.Web.Framework
{
    public static class ExtensionsBuilder
    {
        public static PropertyBuilder<string> AsString(this PropertyBuilder<string> propertyBuilder, int maxLength)
        {
            propertyBuilder.HasColumnType($"nvarchar({maxLength})");
            return propertyBuilder;
        }
    }
}
