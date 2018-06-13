using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvx.Startup))]
namespace mvx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
