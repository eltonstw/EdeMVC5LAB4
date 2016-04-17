using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB.WEB.Startup))]
namespace LAB.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
