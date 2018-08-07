using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KOBinding.web.Startup))]
namespace KOBinding.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
