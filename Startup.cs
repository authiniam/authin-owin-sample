using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthinOwinSample.Startup))]
namespace AuthinOwinSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
