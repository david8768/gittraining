using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gittraing.Startup))]
namespace gittraing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
