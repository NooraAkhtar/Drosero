using Drosero.Domain.Interfaces;
using Drosero.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace DroseroMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UnityConfig.RegisterTypes(UnityConfig.Container);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            SaveHitCounter();
        }

        private int SaveHitCounter()
        {
            var service = UnityConfig.Container.Resolve<IApplicationService<int>>();
            var value = 0;
            if (service != null)
            {
                value = service.Save(0);
            }

            return value;
        }       
    }
}
