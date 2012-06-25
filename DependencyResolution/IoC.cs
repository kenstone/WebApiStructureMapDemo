using StructureMap;
using WebApiStructureMapDemo.Models;

namespace WebApiStructureMapDemo.DependencyResolution {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            //x.For<ISampleFish>().Use<SampleFish>();
                        });
            return ObjectFactory.Container;
        }
    }
}