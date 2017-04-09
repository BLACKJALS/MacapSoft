using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MacapSoft.Startup))]
namespace MacapSoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
