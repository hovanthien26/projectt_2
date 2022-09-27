using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Modbus_RTU_With_ASP.Net_MVC_Sample.Models.WebClientApp.Models.Services;

[assembly: OwinStartup(typeof(Modbus_RTU_With_ASP.Net_MVC_Sample.Startup))]

namespace Modbus_RTU_With_ASP.Net_MVC_Sample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            const uint NumberOfPoints = 12;
            ModbusRTUProtocol objModbusRTUProtocol = new ModbusRTUProtocol(NumberOfPoints);
            objModbusRTUProtocol.Start();
            app.MapSignalR();
        }
    }
}
