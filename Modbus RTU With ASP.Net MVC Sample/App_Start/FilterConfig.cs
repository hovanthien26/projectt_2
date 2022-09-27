using System.Web;
using System.Web.Mvc;

namespace Modbus_RTU_With_ASP.Net_MVC_Sample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
