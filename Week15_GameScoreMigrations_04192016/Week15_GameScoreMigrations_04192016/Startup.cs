using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week15_GameScoreMigrations_04192016.Startup))]
namespace Week15_GameScoreMigrations_04192016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
