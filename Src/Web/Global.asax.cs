using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterAutofac();
        }

        protected void RegisterAutofac()
        {
            var builder = new ContainerBuilder();



            //builder.RegisterType<Repository.AutoFac.Testa>().As<Repository.AutoFac.ITest>();
            builder.Register((u, i) =>
            {
                var obj = new Repository.AutoFac.Testa();
                obj.TestField = "123";
                return obj;
            }).As<Repository.AutoFac.ITest>();

            Repository.AutoFac.DIContainer.RegisterBuilder(builder);
        }
    }
}
