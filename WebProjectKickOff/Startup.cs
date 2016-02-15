using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProjectKickOff.Startup))]
namespace WebProjectKickOff
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
