using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantRater.Startup))]
namespace ResturantRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
