using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebAPI.StartupOwin))]

namespace WebAPI
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
