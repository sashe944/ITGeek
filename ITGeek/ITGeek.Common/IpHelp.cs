using System.Net;
using System.Net.Sockets;

namespace Project.Common
{
   public class IpHelp
    {
        public static string GetIpAdress()
        {
            IPHostEntry SystemAC = Dns.GetHostEntry(Dns.GetHostName());
            string ipAdress = string.Empty;
            foreach (var address in SystemAC.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAdress = address.ToString();

                }
            }
            return ipAdress;
        }
    }
}
