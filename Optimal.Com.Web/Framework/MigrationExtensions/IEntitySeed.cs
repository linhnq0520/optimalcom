using Microsoft.EntityFrameworkCore;

namespace Optimal.Com.Web.Framework.MigrationExtensions
{
    public interface IEntitySeed
    {
        void SeedData(ModelBuilder modelBuilder);
    }

}
