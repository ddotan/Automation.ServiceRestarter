using Automation.Restarter.Agent.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Contract
{
    [ServiceContract]
    public interface IRestartService
    {
        [OperationContract]
        Result RestartService(string i_ServiceName);

        [OperationContract]

        string GetComputerHostname();
        [OperationContract]

        string GetComputerIP();

        [OperationContract]
        Dictionary<string, string> GetServices();

    }
}
