using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheRooferDirect.Startup))]
namespace TheRooferDirect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
