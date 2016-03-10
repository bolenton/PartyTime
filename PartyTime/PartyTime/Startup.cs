using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartyTime.Startup))]
namespace PartyTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
