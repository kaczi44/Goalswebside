using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoalsWebsite.Startup))]
namespace GoalsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
