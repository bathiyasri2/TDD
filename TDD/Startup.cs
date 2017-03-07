using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDD.Startup))]
namespace TDD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
