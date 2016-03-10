using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RsvpApp.Startup))]
namespace RsvpApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
