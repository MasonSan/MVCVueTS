using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCVueTS.Startup))]
namespace MVCVueTS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
