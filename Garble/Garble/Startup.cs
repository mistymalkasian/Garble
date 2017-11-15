using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Garble.Startup))]
namespace Garble
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
