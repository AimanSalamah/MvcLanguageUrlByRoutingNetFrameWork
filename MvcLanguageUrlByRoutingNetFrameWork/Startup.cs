using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLanguageUrlByRoutingNetFrameWork.Startup))]
namespace MvcLanguageUrlByRoutingNetFrameWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
