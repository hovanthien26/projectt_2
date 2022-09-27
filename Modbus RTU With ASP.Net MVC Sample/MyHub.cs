using Microsoft.AspNet.SignalR;

namespace Modbus_RTU_With_ASP.Net_MVC_Sample
{
    public class MyHub : Hub
    {
        public static void SendMessage(int addr, ushort value)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            context.Clients.All.SendMessage(addr, value);
        }
    }
}