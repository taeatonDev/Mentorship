using IGotThisShit.Lib.Configuration;
using IGotThisShit.Service.Providers;
using log4net;
using StructureMap;
using StructureMap.Pipeline;

namespace IGotThisShit.Service.Configuration
{
    public class Configuration
    {
        public static void Configure()
        {
            ObjectFactory.Configure(conf =>
            {
                conf.Scan(scan =>
                {
                    scan.Convention<NestedInheritanceConvention>();
                    scan.AssemblyContainingType(typeof(Data.Configuration.Configuration));
                });

                conf.For<ILog>()
                    .LifecycleIs(new UniquePerRequestLifecycle())
                    .Use(context => LogManager.GetLogger(context.ParentType ?? typeof(object)));

                conf.For<IDataProvider>().Use<HomeDataProvider>();
            });
            Objects.Configuration.Configuration.Configure();
        }
    }
}
