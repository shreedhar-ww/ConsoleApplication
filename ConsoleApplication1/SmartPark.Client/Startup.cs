using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartPark.Client.Startup))]
namespace SmartPark.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
