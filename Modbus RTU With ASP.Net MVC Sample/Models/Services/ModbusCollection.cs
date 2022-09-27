using Modbus_RTU_With_ASP.Net_MVC_Sample.Models.Cores;
using System.Collections.Generic;

namespace Modbus_RTU_With_ASP.Net_MVC_Sample.Models.Services
{
    public class ModbusCollection
    {
        private static List<Memory> _Registers = new List<Memory>();

        public static List<Memory> Registers
        {
            get
            {
                return _Registers;
            }
            set
            {
                _Registers = value;
            }
        }
    }
}
