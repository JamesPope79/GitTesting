using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWebsiteForGit.Startup))]
namespace MvcWebsiteForGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
