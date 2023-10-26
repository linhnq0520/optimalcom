using System.Reflection;
using System.Runtime.Loader;

namespace Optimal.Com.Web.Framework.Infrastructure
{
    public static class AppDomainInfrastructure
    {
        public static IEnumerable<Type> FindClassesOfType<T>()
        {
            var interfaceType = typeof(T);
            var entryAssembly = Assembly.GetEntryAssembly();
            var assemblyLoadContext = AssemblyLoadContext.GetLoadContext(entryAssembly);
            var loadedAssemblies = assemblyLoadContext.Assemblies;

            var implementingClasses = loadedAssemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => interfaceType.IsAssignableFrom(t) && !t.IsInterface);

            return implementingClasses;
        }
        
    }
}
