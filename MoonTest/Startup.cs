using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoonTest.Startup))]
namespace MoonTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
