using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using SmartRent.Core.Misc;

namespace SmartRent.AdminSite
{
    static class AutofacConfig
    {
        public static void Initialize()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterApplicationTypes();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}