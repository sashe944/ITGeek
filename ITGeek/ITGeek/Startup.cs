using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITGeek.Startup))]
namespace ITGeek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
