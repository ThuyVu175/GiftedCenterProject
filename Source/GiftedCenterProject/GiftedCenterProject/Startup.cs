using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiftedCenterProject.Startup))]
namespace GiftedCenterProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
