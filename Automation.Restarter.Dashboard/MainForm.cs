using Automation.Restarter.Dashboard.Core;
using Automation.Restarter.Dashboard.Core.Repository;
using Automation.Restarter.Dashboard.ObjectModel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automation.Restarter.Dashboard
{
    public partial class MainForm : Form
    {
        private DashboardManager m_DashboardManager;
        private LoadingForm m_LoadingForm = new LoadingForm();
        public MainForm()
        {
            InitializeComponent();
            SystemLogManager.Instance.SetDataGridView(dataGridViewLogs);
            m_DashboardManager = DashboardManager.Instance;
            loadServicesDataGrid();
    
        }
        private void loadServicesDataGrid()
        {
            var agents = AgentsManager.Instance.m_Agents;
            string machineName, IP = string.Empty;
            foreach(var agent in agents)
            {
                machineName = agent.Value.ComputerName;
                IP = agent.Value.IP;
                foreach(var service in agent.Value.Services)
                {
                    dataGridViewServices.Rows.Add(new string[] { machineName,IP,service.Key });
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int xPos= this.Left + (this.Width/2);
            int yPos = this.Top + (this.Height / 2);
            string x = Interaction.InputBox("Please enter password", "Password verfing", string.Empty, xPos-100, yPos-100);
            if(x.ToLower() == "tech987")
            {
                m_LoadingForm.Show();
                m_DashboardManager.RestartAllAgentsService();
                m_LoadingForm.Close();
            }
          
        }
    }
}
