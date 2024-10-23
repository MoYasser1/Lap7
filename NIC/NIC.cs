using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIC
{
    public class NIC
    {
        private static NIC instance = null;

        public string Manufacture { get; private set; }
        public string MACAddress { get; private set; }
        public NICType Type { get; private set; }
        private NIC(string manufacture, string macAddress, NICType type)
        {
            Manufacture = manufacture;
            MACAddress = macAddress;
            Type = type;
        }
        public static NIC GetInstance(string manufacture, string macAddress, NICType type)
        {
            if (instance == null)
            {
                instance = new NIC(manufacture, macAddress, type);
            }
            return instance;
        }
        public enum NICType
        {
            Ethernet,
            TokenRing
        }

    }

}
