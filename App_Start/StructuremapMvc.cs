    using System.Web.Http;
    using System.Web.Mvc;
using StructureMap;
    using WebApiStructureMapDemo.DependencyResolution;

[assembly: WebActivator.PreApplicationStartMethod(typeof(WebApiStructureMapDemo.App_Start.StructuremapMvc), "Start")]

namespace WebApiStructureMapDemo.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
           var container = (IContainer)IoC.Initialize();
          //  var container = ObjectFactory.Container;
            GlobalConfiguration.Configuration.DependencyResolver = new SmDependencyResolver(container);

        }
    }
}