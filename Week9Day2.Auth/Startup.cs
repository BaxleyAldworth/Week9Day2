using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week9Day2.Auth.Startup))]
namespace Week9Day2.Auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
