using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAppGit.Startup))]
namespace DemoAppGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
