using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VendasAspNetMVC.Startup))]
namespace VendasAspNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
