using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTraining.Startup))]
namespace GitTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
