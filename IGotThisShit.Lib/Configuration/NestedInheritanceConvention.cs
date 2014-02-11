using System;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace IGotThisShit.Lib.Configuration
{
    public class NestedInheritanceConvention : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (type == null || registry == null)
                return;

            if (type.IsInterface ||
                type.IsAbstract ||
                type.IsSubclassOf(typeof(Registry))
                )
                return;

            foreach (var iface in type.GetInterfaces())
            {
                registry.For(iface).Use(type);
            }
        }
    }
}
