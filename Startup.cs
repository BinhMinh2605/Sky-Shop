using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sky_shop.Startup))]
namespace sky_shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
