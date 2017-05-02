using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartRent.AdminSite.Startup))]
namespace SmartRent.AdminSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
