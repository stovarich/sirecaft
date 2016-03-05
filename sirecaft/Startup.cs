using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sirecaft.Startup))]
namespace sirecaft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
