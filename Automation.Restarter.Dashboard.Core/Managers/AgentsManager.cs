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

namespace Automation.Restarter.Dashboard.Core
{
    public class AgentsManager
    {
        public Dictionary<string, AgentInstance> m_Agents = new Dictionary<string, AgentInstance>();
        private readonly string m_EndPointsFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\EndPoints.xml";

        private static AgentsManager m_Instance;
        public static AgentsManager Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new AgentsManager();
                }
                return m_Instance;
            }
        }
        private void loadEndPoints()
        {
            List<string> endPoints = XMLUtils.DeSerilize<List<string>>(m_EndPointsFilePath);
            IRestartService restartService = null;
            AgentInstance agentInstance = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string fullEndPoint = string.Empty;
            LogManager.Instance.WriteInfo("CreateChannel operation on endpoints started");
            foreach (string endpoint in endPoints)
            {
                try
                {
                    fullEndPoint = "http://" + endpoint + ":5050/RestartService";
                    restartService = WCFUtils.ServiceFactory<IRestartService>.GetService(fullEndPoint);
                    agentInstance = new AgentInstance(restartService);
                    agentInstance.UpdateInstanceInfo();
                    m_Agents.Add(agentInstance.IP, agentInstance);
                }
                catch (Exception ex)
                {
                    SystemLogManager.Instance.Log(eLogType.Error, "TryingCreateChannel", fullEndPoint, string.Empty, ex.Message, string.Empty);
                    LogManager.Instance.WriteError("Error while trying to CreateChannel , [Endpoint]: " + fullEndPoint + " [Exception]: " + ex.Message);
                }
            }
            sw.Stop();
            LogManager.Instance.WriteInfo("CreateChannel operation on endpoints ended, elapsed: " + sw.Elapsed);
        }
        private AgentsManager()
        {
            loadEndPoints();
        }
        public void TakeAction(string i_MachineName, string i_IP, string i_ServiceName, string i_DisplayName)
        {
            LogManager.Instance.WriteInfo("TakeAction action against, [MachineName]: " + i_MachineName + " [IP]: " + i_IP + " [ServiceName]: " + i_ServiceName + " [DisplayName]: " + i_DisplayName + " => Started");
            AgentInstance agentInstance;
            try
            {
                agentInstance = m_Agents[i_IP];
                Result result = agentInstance.RestartService.RestartService(i_ServiceName);
                if (result.Done == true)
                {
                    SystemLogManager.Instance.Log(eLogType.Info, agentInstance, i_DisplayName, "Success", result.Elapsed.ToString());
                    LogManager.Instance.WriteInfo("TakeAction action against, [MachineName]: " + i_MachineName + " [IP]: " + i_IP + " [ServiceName]: " + i_ServiceName + " [DisplayName]: " + i_DisplayName + " => Done, [Result]: Success" + " [Elapsed]: " + result.Elapsed.ToString());

                }
                else
                {
                    LogManager.Instance.WriteInfo("TakeAction action against, [MachineName]: " + i_MachineName + " [IP]: " + i_IP + " [ServiceName]: " + i_ServiceName + " [DisplayName]: " + i_DisplayName + " => Done, [Result]: Failed");
                    foreach (Result res in result.InnerResults)
                    {
                        LogManager.Instance.WriteInfo("[Service]: " + res.Name + " [Action]: " + Enum.GetName(typeof(eOperationType), res.OperationType) + " [Exception]: " + res.Exception + " [Elapsed]: " + res.Elapsed.ToString());

                    }
                    SystemLogManager.Instance.Log(eLogType.Error, agentInstance, i_DisplayName, "Failed", result.Elapsed.ToString());

                }
            }
            catch (Exception ex)
            {
                LogManager.Instance.WriteError("TakeAction action against, [MachineName]: " + i_MachineName + " [ServiceName]: " + i_ServiceName + " [DisplayName]: " + i_DisplayName + " [Error]: " + ex.Message);
            }
        }
        public void TakeActionOnAllAgents()
        {
            AgentInstance agent = null;
            List<Task> tasks = new List<Task>();
            Task task = null;
            foreach (var keyvalueAgent in m_Agents)
            {
                agent = keyvalueAgent.Value;
                foreach (var service in agent.Services)
                {
                    //    task = new Task(() =>
                    //{
                    TakeAction(agent.ComputerName, agent.IP, service.Value, service.Key);
                    //});
                    //    task.Start();
                    //    tasks.Add(task);

                }
            }
            //Task.WaitAll(tasks.ToArray());
        }
    }
}
