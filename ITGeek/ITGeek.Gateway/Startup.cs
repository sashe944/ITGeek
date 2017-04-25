using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITGeek.Gateway.Startup))]
namespace ITGeek.Gateway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
