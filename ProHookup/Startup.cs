using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProHookup.Startup))]
namespace ProHookup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
