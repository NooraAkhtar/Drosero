using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DroseroMVC.Startup))]
namespace DroseroMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
