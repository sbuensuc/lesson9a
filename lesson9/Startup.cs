using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lesson9.Startup))]
namespace lesson9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
