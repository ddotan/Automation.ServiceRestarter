using Automation.Restarter.Agent.Contract;
using Automation.Restarter.Agent.Core.Repositories;
using Automation.Restarter.Agent.ObjectModel;
using Automation.Restarter.Agent.Utilities;
using Logger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Core.Engines
{
    public class RestartEngine
    {
        private Configurations m_Configurations = Configurations.Instance;

        public Result TakeAction(string i_ServiceName, eOperationType i_OperationType)
        {
            Stopwatch stopWatch = new Stopwatch();
            bool serviceIsRunning = false;
            string exception = string.Empty;
            bool operationDone = true;
            Result result = new Result();
            result.OperationType = i_OperationType;
            stopWatch.Start();
            LogManager.Instance.WriteInfo(i_ServiceName + " => " + Enum.GetName(typeof(eOperationType), i_OperationType) + " Action");
            if (i_OperationType == eOperationType.ServiceRestart)
            {
                try
                {
                    serviceIsRunning = ServiceUtils.isServiceRunning(i_ServiceName);

                }
                catch (Exception ex)
                {
                    exception = "[ServiceName]: " + i_ServiceName + " Not exsists";
                    operationDone = false;
                }
            }
            else
            {
                serviceIsRunning = ServiceUtils.isServiceRunning(i_ServiceName);
            }
            try
            {
                switch (i_OperationType)
                {
                    case eOperationType.StartService:
                        if (!serviceIsRunning)
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(m_Configurations.WaitTimeBetweenActions));
                            ServiceUtils.StartService(i_ServiceName, m_Configurations.ServiceChangeStateWaitTime);

                        }
                        break;
                    case eOperationType.StopService:
                        if (serviceIsRunning)
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(m_Configurations.WaitTimeBetweenActions));
                            ServiceUtils.StopService(i_ServiceName, m_Configurations.ServiceChangeStateWaitTime);
                        }
                        break;
                    case eOperationType.ServiceRestart:
                        try
                        {
                            result.AddResult(TakeAction(i_ServiceName, eOperationType.StopService));
                            result.AddResult(TakeAction(i_ServiceName, eOperationType.StartService));
                        }
                        catch (Exception ex)
                        {
                            exception = ex.Message;
                        }
                        break;
                    default:
                        result.AddResult(i_ServiceName, i_OperationType, stopWatch.Elapsed, true);
                        break;
                }

            }
            catch (Exception ex)
            {
                operationDone = false;
                result.AddResult(i_ServiceName, i_OperationType, stopWatch.Elapsed, false, ex.Message);
                LogManager.Instance.WriteError(i_ServiceName + " => " + Enum.GetName(typeof(eOperationType), i_OperationType) + " Failed ! with exception: " + ex.Message);
            }
            stopWatch.Stop();
            result.Elapsed = stopWatch.Elapsed;
            result.Exception = exception;
            result.Done = operationDone;
            return result;
        }

    }
}
