using Automation.Restarter.Agent.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Restarter.Agent.Core.Repositories
{
    public class ServicesRepository
    {
        private readonly string m_FilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Settings\\Services.xml";
        private static ServicesRepository m_Instance;
        private ServicesRepository()
        {
            Services = XMLUtils.DictionaryDeSerlize(m_FilePath);
        }
        public Dictionary<string, string> Services { get; set; }
        public static ServicesRepository Instance { get { if (m_Instance == null) { m_Instance = new ServicesRepository(); } return m_Instance; } }
        public void Save()
        {
            XMLUtils.DictionarySerlize(m_FilePath,Services);
        }
    }
}
