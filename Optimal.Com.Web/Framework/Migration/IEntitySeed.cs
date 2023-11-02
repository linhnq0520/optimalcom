using Microsoft.EntityFrameworkCore;

namespace Optimal.Com.Web.Framework.Migration
{
    public interface IEntitySeed
    {
        void SeedData(ModelBuilder modelBuilder);
    }

}
