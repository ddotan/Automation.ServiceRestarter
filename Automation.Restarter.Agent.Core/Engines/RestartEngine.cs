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
            string exception = string.Empty;
            bool operationDone = true;
            Result result = new Result();
            result.OperationType = i_OperationType;
            stopWatch.Start();
            LogManager.Instance.WriteInfo(i_ServiceName + " => " + Enum.GetName(typeof(eOperationType), i_OperationType) + ", action started");
            try
            {
                switch (i_OperationType)
                {
                    case eOperationType.StartService:
                        if (!ServiceUtils.isServiceRunning(i_ServiceName))
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(m_Configurations.WaitTimeBetweenActions));
                            ServiceUtils.StartService(i_ServiceName, m_Configurations.ServiceChangeStateWaitTime);

                        }
                        break;
                    case eOperationType.StopService:
                        if (ServiceUtils.isServiceRunning(i_ServiceName))
                        {
                            ServiceUtils.StopService(i_ServiceName, m_Configurations.ServiceChangeStateWaitTime);
                            Thread.Sleep(TimeSpan.FromSeconds(m_Configurations.WaitTimeBetweenActions));
                        }
                        break;
                    case eOperationType.RestartService:
                        try
                        {
                            result.AddResult(TakeAction(i_ServiceName, eOperationType.StopService));
                            result.AddResult(TakeAction(i_ServiceName, eOperationType.StartService));
                            if (isMainOperationDone(result, eOperationType.StartService))
                            {
                                operationDone = true;
                            }
                            else
                            {
                                if (ServiceUtils.isServiceRunning(i_ServiceName))
                                {
                                    operationDone = true;
                                }
                                else
                                {
                                    operationDone = false;
                                }

                            }

                        }
                        catch (Exception ex)
                        {
                            exception = ex.Message;
                            operationDone = false;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                operationDone = false;
                exception = ex.Message;
                LogManager.Instance.WriteError(i_ServiceName + " => " + Enum.GetName(typeof(eOperationType), i_OperationType) + " faulted! with exception: " + ex.Message);
            }

            LogManager.Instance.WriteInfo(i_ServiceName + " => " + Enum.GetName(typeof(eOperationType), i_OperationType) + ", action ended ,took: " + stopWatch.Elapsed.ToString());

            stopWatch.Stop();
            result.Elapsed = stopWatch.Elapsed;
            result.Exception = exception;
            result.Done = operationDone;
            return result;
        }
        bool isMainOperationDone(Result i_Result, eOperationType i_MostImportantAction)
        {
            bool mainOperationDone = false;
            Result LastOperationInProdecureResult = i_Result.InnerResults.Find(x => x.OperationType == i_MostImportantAction);
            if(LastOperationInProdecureResult != null)
            {
                mainOperationDone= LastOperationInProdecureResult.Done;
            }
            return mainOperationDone;
        }


    }
}
