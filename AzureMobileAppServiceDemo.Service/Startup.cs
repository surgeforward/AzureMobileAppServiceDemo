using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AzureMobileAppServiceDemo.Service.Startup))]

namespace AzureMobileAppServiceDemo.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}