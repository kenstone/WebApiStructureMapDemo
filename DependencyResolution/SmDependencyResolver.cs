using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using StructureMap;

namespace WebApiStructureMapDemo.DependencyResolution
{

    public class SmDependencyResolver : StructureMapScope, IDependencyResolver
    {
        private IContainer _container;

        public SmDependencyResolver(IContainer container)
            : base(container)
        {
            _container = container;
        }

        public IDependencyScope BeginScope()
        {
            _container = (IContainer)IoC.Initialize();
            return new StructureMapScope(_container);
        }
    }


    //public class SmDependencyResolver : IDependencyResolver {

    //    private readonly IContainer _container;

    //    public SmDependencyResolver(IContainer container) {
    //        _container = container;
    //    }

    //    public object GetService(Type serviceType) {
    //        if (serviceType == null) return null;
    //        try {
    //              return serviceType.IsAbstract || serviceType.IsInterface
    //                       ? _container.TryGetInstance(serviceType)
    //                       : _container.GetInstance(serviceType);
    //        }
    //        catch {

    //            return null;
    //        }
    //    }

    //    public IEnumerable<object> GetServices(Type serviceType) {
    //        return _container.GetAllInstances(serviceType).Cast<object>();
    //    }
    //}
}