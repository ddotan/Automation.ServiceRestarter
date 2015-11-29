using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Utilities
{
    public static class NetworkUtils
    {
        public static string GetComputerHostName()
        {
            string machineName = Environment.MachineName.ToString();
            return machineName;
        }
        public static string GetComputerIP()
        {
            string localIP = string.Empty;
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return localIP;
        }
    }

}
