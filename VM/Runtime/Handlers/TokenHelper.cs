namespace Squire.VM.Runtime.Handlers
{
    public class TokenHelper
    {
        public static MethodInfo ForceResolveMethod(int mdtoken)
        {
            foreach(var module in Assembly.GetEntryAssembly().Modules)
            {
                if (module.ResolveMethod(mdtoken) != null)
                    return (MethodInfo)module.ResolveMethod(mdtoken);
            }

            return null;
        }

        public static Type ForceResolveType(int mdtoken)
        {
            foreach(var module in Assembly.GetEntryAssembly().Modules)
            {
                if (module.ResolveType(mdtoken) != null)
                    return (Type)module.ResolveType(mdtoken);
            }

            return null;
        }

        public static ConstructorInfo ForceResolveConstructor(int mdtoken)
        {
            foreach(var module in Assembly.GetEntryAssembly().Modules)
            {
                if (module.ResolveMethod(mdtoken) != null)
                    return (ConstructorInfo)module.ResolveMethod(mdtoken);
            }

            return null;
        }

        public static MethodBase ForceResolveMember(int mdtoken)
        {
            foreach(var module in Assembly.GetEntryAssembly().Modules)
            {
                if (module.ResolveMember(mdtoken) != null)
                    return (MethodBase)module.ResolveMember(mdtoken);
            }

            return null;
        }

        public static FieldInfo ForceResolveField(int mdtoken)
        {
            foreach (var module in Assembly.GetEntryAssembly().Modules)
            {
                if (module.ResolveField(mdtoken) != null)
                    return (FieldInfo)module.ResolveField(mdtoken);
            }

            return null;
        }
    }
}