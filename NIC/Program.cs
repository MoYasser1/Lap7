using static NIC.NIC;

namespace NIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC myNIC = NIC.GetInstance("Intel", "00-14-22-01-23-45", NICType.Ethernet);
            Console.WriteLine($"Manufacture: {myNIC.Manufacture}");
            Console.WriteLine($"MAC Address: {myNIC.MACAddress}");
            Console.WriteLine($"Type: {myNIC.Type}");
        }
    }
}
