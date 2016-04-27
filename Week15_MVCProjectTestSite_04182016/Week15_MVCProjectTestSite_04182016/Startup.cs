using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week15_MVCProjectTestSite_04182016.Startup))]
namespace Week15_MVCProjectTestSite_04182016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
