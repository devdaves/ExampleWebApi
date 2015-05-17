using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Castle.Windsor;
using ExampleWebApi.Windsor;
using ExampleWebApi.Windsor.Installers;
using Owin;

namespace ExampleWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var container = new WindsorContainer().Install(
                new ControllerInstaller(), 
                new DefaultInstaller());
            var httpDependencyResolver = new WindsorHttpDependencyResolver(container);

            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.DependencyResolver = httpDependencyResolver;
            appBuilder.UseWebApi(config);
        }
    }
}