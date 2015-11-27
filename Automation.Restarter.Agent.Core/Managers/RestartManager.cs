using Automation.Restarter.Agent.Contract;
using Automation.Restarter.Agent.Core.Engines;
using Automation.Restarter.Agent.Core.Repositories;
using Automation.Restarter.Agent.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Core.Managers
{
    public class RestartManager : IRestartService
    {
        private ServicesRepository m_ServicesRepository = ServicesRepository.Instance;
        private RestartEngine m_RestartEngine = new RestartEngine();

        public ObjectModel.Result RestartService(string i_ServiceName)
        {
            return m_RestartEngine.TakeAction(i_ServiceName, ObjectModel.eOperationType.ServiceRestart);
        }

        public string GetComputerHostname()
        {
            return NetworkUtils.GetComputerHostName();
        }

        public string GetComputerIP()
        {
            return NetworkUtils.GetComputerIP();
        }

        public Dictionary<string, string> GetServices()
        {
            return m_ServicesRepository.Services;
        }
    }
}
