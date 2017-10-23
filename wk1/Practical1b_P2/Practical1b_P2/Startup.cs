using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practical1b_P2.Startup))]
namespace Practical1b_P2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
