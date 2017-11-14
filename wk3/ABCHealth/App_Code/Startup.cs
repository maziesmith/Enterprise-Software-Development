using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABCHealth.Startup))]
namespace ABCHealth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
