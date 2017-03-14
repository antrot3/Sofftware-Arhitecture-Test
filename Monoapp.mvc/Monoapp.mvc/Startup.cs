using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monoapp.mvc.Startup))]
namespace Monoapp.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
