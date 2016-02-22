using System;

namespace ShadowCore
{
    public static class DependencyControl
    {
        public static string IncludeTypeAssemblyDependency(this Type type)
        {
            return type.ToString();
        }
    }
}
