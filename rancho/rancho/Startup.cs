using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rancho.Startup))]
namespace rancho
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
