namespace Automation.Restarter.Dashboard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAgents = new System.Windows.Forms.DataGridView();
            this.btnRestartAll = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAgents
            // 
            this.dataGridViewAgents.AllowUserToAddRows = false;
            this.dataGridViewAgents.AllowUserToDeleteRows = false;
            this.dataGridViewAgents.AllowUserToResizeColumns = false;
            this.dataGridViewAgents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentMachineName,
            this.agentIP,
            this.agentServiceName});
            this.dataGridViewAgents.Location = new System.Drawing.Point(204, 33);
            this.dataGridViewAgents.Name = "dataGridViewAgents";
            this.dataGridViewAgents.RowHeadersWidth = 4;
            this.dataGridViewAgents.Size = new System.Drawing.Size(459, 248);
            this.dataGridViewAgents.TabIndex = 0;
            // 
            // btnRestartAll
            // 
            this.btnRestartAll.BackColor = System.Drawing.Color.LightGray;
            this.btnRestartAll.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartAll.ForeColor = System.Drawing.Color.Crimson;
            this.btnRestartAll.Location = new System.Drawing.Point(376, 287);
            this.btnRestartAll.Name = "btnRestartAll";
            this.btnRestartAll.Size = new System.Drawing.Size(120, 52);
            this.btnRestartAll.TabIndex = 1;
            this.btnRestartAll.Text = "Restart All";
            this.btnRestartAll.UseVisualStyleBackColor = false;
            this.btnRestartAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLogs.CausesValidation = false;
            this.dataGridViewLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridViewLogs.ColumnHeadersHeight = 26;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Type,
            this.MachineName,
            this.IP,
            this.ServiceName,
            this.Information});
            this.dataGridViewLogs.EnableHeadersVisualStyles = false;
            this.dataGridViewLogs.Location = new System.Drawing.Point(2, 378);
            this.dataGridViewLogs.MultiSelect = false;
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.RowHeadersWidth = 4;
            this.dataGridViewLogs.ShowCellToolTips = false;
            this.dataGridViewLogs.Size = new System.Drawing.Size(1030, 150);
            this.dataGridViewLogs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 80;
            // 
            // MachineName
            // 
            this.MachineName.HeaderText = "MachineName";
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            this.MachineName.Width = 130;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 90;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 120;
            // 
            // Information
            // 
            this.Information.HeaderText = "Information";
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.Width = 280;
            // 
            // agentMachineName
            // 
            this.agentMachineName.HeaderText = "MachineName";
            this.agentMachineName.Name = "agentMachineName";
            this.agentMachineName.ReadOnly = true;
            this.agentMachineName.Width = 150;
            // 
            // agentIP
            // 
            this.agentIP.HeaderText = "MachineIP";
            this.agentIP.Name = "agentIP";
            this.agentIP.ReadOnly = true;
            this.agentIP.Width = 150;
            // 
            // agentServiceName
            // 
            this.agentServiceName.HeaderText = "ServiceName";
            this.agentServiceName.Name = "agentServiceName";
            this.agentServiceName.ReadOnly = true;
            this.agentServiceName.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(857, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.btnRestartAll);
            this.Controls.Add(this.dataGridViewAgents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgents;
        private System.Windows.Forms.Button btnRestartAll;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentServiceName;
    }
}