using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Utilities
{
    public static class ServiceUtils
    {
        public static void StartService(string i_ServiceName, int i_ServiceChangeTimeoutInSconds)
        {
            ServiceController service = new ServiceController(i_ServiceName);
            if (isServiceRunning(i_ServiceName))
            {
                throw new Exception("Service already running.");
            }
            TimeSpan timeout = TimeSpan.FromSeconds(i_ServiceChangeTimeoutInSconds);
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, timeout);
        }
        public static bool isServiceRunning(string i_ServiceName)
        {
            ServiceController service = new ServiceController(i_ServiceName);
            return (service.Status == ServiceControllerStatus.Running);
        }
        public static void StopService(string i_ServiceName, int i_ServiceChangeTimeoutInSconds)
        {
            ServiceController service = new ServiceController(i_ServiceName);
            TimeSpan timeout = TimeSpan.FromSeconds(i_ServiceChangeTimeoutInSconds);
            service.Stop();
            service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
        }
    }
}
