using Automation.Restarter.Agent.Contract;
using Automation.Restarter.Agent.Core.Managers;
using Automation.Restarter.Agent.Core.Repositories;
using Logger;
using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Host
{
    class Program : ServiceBase
    {
        public ServiceHost m_ServiceHost = null;
        static void Main(string[] args)
        {
            ServicesRepository s = ServicesRepository.Instance;
            if (System.Environment.UserInteractive)
            {
                string parameter = string.Concat(args);
                switch (parameter.ToLower())
                {
                    case "-install":
                        ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
                        LogManager.Instance.WriteInfo("Service Installed.");

                        break;
                    case "-console":

                        runProgram();
                        while (true)
                        {

                        }

                        break;
                }
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
            try
            {
                RestartManager rs = new RestartManager();
                ServiceHost serviceHost = new ServiceHost(typeof(RestartManager));
                serviceHost.Open();
                LogManager.Instance.WriteInfo("RestarterServices Server Started...........");
            }
            catch (Exception ex)
            {
                LogManager.Instance.WriteError("Error while trying load RestarterServices agent : " + ex.Message);
            }

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
