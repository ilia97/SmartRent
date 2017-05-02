using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartRent.ManagerSite.Startup))]
namespace SmartRent.ManagerSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
