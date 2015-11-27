using Automation.Restarter.Agent.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Dashboard.ObjectModel
{
    public class AgentInstance
    {
        public string ComputerName { get; set; }
        public string IP { get; set; }
        public Dictionary<string, string> Services;
        public IRestartService RestartService;
        public void UpdateInstanceInfo()
        {
            ComputerName = RestartService.GetComputerHostname();
            IP = RestartService.GetComputerIP();
            Services = RestartService.GetServices();
        }
        public AgentInstance(IRestartService i_IRestartService)
        {
            RestartService = i_IRestartService;
        }
    }
}
