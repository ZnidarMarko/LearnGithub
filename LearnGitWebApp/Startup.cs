using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnGitWebApp.Startup))]
namespace LearnGitWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
