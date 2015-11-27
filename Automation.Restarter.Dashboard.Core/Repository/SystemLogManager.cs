using Automation.Restarter.Dashboard.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation.Restarter.Dashboard.Core.Repository
{
    public enum eLogType
    {
        Error, Info
    }
    public class SystemLogManager
    {
        private static SystemLogManager m_Instance;
        public static SystemLogManager Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new SystemLogManager();
                }
                return m_Instance;
            }
        }
        public void SetDataGridView(DataGridView i_DataGridView)
        {
            m_DataGridView = i_DataGridView;
        }
        private SystemLogManager()
        {
        }

        private DataGridView m_DataGridView;

        public void Log(eLogType i_LogType, string i_MachineName, string i_IP, string i_ServiceName, string i_Info,string i_Elapsed)
        {
            Object obj = new object();
            lock (obj)
            {
                string time = DateTime.Now.ToString();
                m_DataGridView.Rows.Add(new string[] { DateTime.Now.ToString(), Enum.GetName(typeof(eLogType), i_LogType), i_MachineName, i_IP, i_ServiceName, i_Info, i_Elapsed });
            }
        }
        public void Log(eLogType i_LogType, AgentInstance i_AgentInstance, string i_ServiceName, string i_Info,string i_Elapsed)
        {
            string machineName = i_AgentInstance.ComputerName;
            string IP = i_AgentInstance.IP;
            Log(i_LogType, machineName, IP, i_ServiceName, i_Info,i_Elapsed);
        }
        public void Log(eLogType i_LogType, AgentInstance i_AgentInstance, string i_Info,string i_Elapsed)
        {
            string machineName = i_AgentInstance.ComputerName;
            string IP = i_AgentInstance.IP;
            Log(i_LogType, machineName, IP, string.Empty, i_Info, i_Elapsed);
        }

    }
}
