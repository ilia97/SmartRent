using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartRent.CustomerSite.Startup))]
namespace SmartRent.CustomerSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
