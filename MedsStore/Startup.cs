using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedsStore.Startup))]
namespace MedsStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
