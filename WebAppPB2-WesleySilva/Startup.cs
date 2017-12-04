using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPB2_WesleySilva.Startup))]
namespace WebAppPB2_WesleySilva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
