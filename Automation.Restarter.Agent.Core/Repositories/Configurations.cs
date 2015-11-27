using Automation.Restarter.Agent.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Core.Repositories
{
    public class Configurations
    {
        private static Configurations m_Instance;
        private Configurations()
        {
            ServiceChangeStateWaitTime = int.Parse(ConfigurationManager.AppSettings["ServiceChangeStateWaitTime"]);
            WaitTimeBetweenActions = int.Parse(ConfigurationManager.AppSettings["WaitTimeBetweenActions"]);
        }

        public static Configurations Instance { get { if (m_Instance == null) { m_Instance = new Configurations(); } return m_Instance; } }

        public int ServiceChangeStateWaitTime { get; set; }
        public int WaitTimeBetweenActions { get; set; }


    }
}
