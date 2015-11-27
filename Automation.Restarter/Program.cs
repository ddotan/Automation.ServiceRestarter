using Automation.Restarter.Agent.Core.Managers;
using Automation.Restarter.Agent.Core.Repositories;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent
{
    class Program : ServiceBase
    {
        public ServiceHost m_ServiceHost = null;
        static void Main(string[] args)
        {
            ServicesRepository s = ServicesRepository.Instance;
            if (System.Environment.UserInteractive)
            {
                runProgram();
                while (true) { };
            }
            else
            {
                ServiceBase.Run(new Program());
            }

        }
        protected override void OnStart(string[] args)
        {
            if (m_ServiceHost != null)
            {
                m_ServiceHost.Close();
            }

            try
            {
                runProgram();
            }
            catch (Exception ex)
            {
                LogManager.Instance.WriteError(ex.Message);
            }
        }

        private static void runProgram()
        {
            RestartManager rs = new RestartManager();
            ServiceHost serviceHost = new ServiceHost(typeof(RestartManager));
            serviceHost.Open();
            LogManager.Instance.WriteInfo("RestarterServices Server Started...........");
        }
        protected override void OnStop()
        {
            if (m_ServiceHost != null)
            {
                m_ServiceHost.Close();
            }
        }
    }
}
