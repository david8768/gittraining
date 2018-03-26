using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gittraining.Startup))]
namespace gittraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
