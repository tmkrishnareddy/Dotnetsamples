using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventsOnboard.Startup))]
namespace EventsOnboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
