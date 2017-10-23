using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDD_RandauRuai.Startup))]
namespace PDD_RandauRuai
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
