using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WineStore.Startup))]
namespace WineStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
