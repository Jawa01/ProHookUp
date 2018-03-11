using Microsoft.Owin;
using Owin;
using ProHookup;

[assembly: OwinStartup(typeof(Startup))]

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