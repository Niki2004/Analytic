using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Analytic.Startup))]
namespace Analytic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
