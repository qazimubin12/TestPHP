using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestPHP.Startup))]
namespace TestPHP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
