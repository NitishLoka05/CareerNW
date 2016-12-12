using Autofac;
using CareerNW.RepoEF.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CareerNW.ServiceWebAPI
{
    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
                       
            //Register types
            builder.RegisterType<VendorComponent>().As<IVendorComponent>().InstancePerRequest();

            //Register Modules
            builder.RegisterAssemblyTypes(typeof(WebApiApplication).Assembly).PropertiesAutowired();

            //builder.RegisterAssemblyTypes(Assembly.Load("CareerNW.Facade"))
            //       .Where(t => t.Name.EndsWith("Facade"))
            //       .AsImplementedInterfaces()
            //      .SingleInstance();

            //builder.RegisterAssemblyTypes(Assembly.Load("CareerNW.RepoEF"))
            //       .Where(t => t.Name.EndsWith("Component"))
            //       .AsImplementedInterfaces()
            //      .SingleInstance();

            var container = builder.Build();
            return container;
        }
    }
}