using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.ObjectModel
{
    public enum eOperationType
    {
        StartService,
        StopService,
        ServiceRestart,
        RestartService
    }
}
