using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise_1.Startup))]
namespace Exercise_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
