using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(harman_asg2.Startup))]
namespace harman_asg2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
