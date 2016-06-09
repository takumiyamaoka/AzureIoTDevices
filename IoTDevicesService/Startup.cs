using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(IoTDevicesService.Startup))]

namespace IoTDevicesService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}