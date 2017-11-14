using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(practical_2a.Startup))]
namespace practical_2a
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
