using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent
{

  [RunInstaller(true)]
  public class SolutionInstaller : Installer
  {
      private ServiceProcessInstaller process;
      private ServiceInstaller service;

      public SolutionInstaller()
      {
          process = new ServiceProcessInstaller();
          process.Account = ServiceAccount.LocalSystem;
          service = new ServiceInstaller();
          service.ServiceName = "TechSupport Restart Agent v1.0";
          Installers.Add(process);
          Installers.Add(service);
      }
  }

}
