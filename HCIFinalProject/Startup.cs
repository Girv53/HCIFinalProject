using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCIFinalProject.Startup))]
namespace HCIFinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
