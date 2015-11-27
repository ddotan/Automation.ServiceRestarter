using Automation.Restarter.Dashboard.Core;
using Automation.Restarter.Dashboard.Core.Repository;
using Automation.Restarter.Dashboard.ObjectModel;
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
        public MainForm()
        {
            InitializeComponent();
            SystemLogManager.Instance.SetDataGridView(dataGridViewLogs);
            m_DashboardManager = DashboardManager.Instance; 
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_DashboardManager.RestartAllAgentsService();
        }
    }
}
