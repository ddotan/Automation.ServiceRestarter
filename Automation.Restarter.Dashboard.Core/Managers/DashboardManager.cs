using Automation.Restarter.Agent.Contract;
using Automation.Restarter.Agent.ObjectModel;
using Automation.Restarter.Agent.Utilities;
using Automation.Restarter.Dashboard.Core.Repository;
using Automation.Restarter.Dashboard.ObjectModel;
using Automation.Restarter.Dashboard.Utilities;
using Logger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Automation.Restarter.Dashboard.Core
{
    public class DashboardManager
    {
        private AgentsManager m_AgentsManager = AgentsManager.Instance;
        private DashboardManager()
        {
            LogManager.Instance.WriteInfo("DashboardManager started");
        }

        private static DashboardManager m_Instance;
        public static DashboardManager Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new DashboardManager();
                }
                return m_Instance;
            }
        }
        public void RestartAllAgentsService()
        {
            m_AgentsManager.TakeActionOnAllAgents(eOperationType.ServiceRestart);
        }
        public void TakeAction(string i_MachineName, string i_IP, string i_ServiceName,string i_DisplayName, eOperationType i_OperationType)
        {
            m_AgentsManager.TakeAction(i_MachineName, i_IP, i_ServiceName, i_DisplayName, i_OperationType);
        }
    }
}
