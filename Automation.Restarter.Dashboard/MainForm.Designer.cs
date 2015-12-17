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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.agentMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRestartAll = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AllowUserToResizeColumns = false;
            this.dataGridViewServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentMachineName,
            this.agentIP,
            this.agentServiceName});
            this.dataGridViewServices.Location = new System.Drawing.Point(238, 39);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 4;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewServices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServices.Size = new System.Drawing.Size(458, 230);
            this.dataGridViewServices.TabIndex = 0;
            // 
            // agentMachineName
            // 
            this.agentMachineName.HeaderText = "Machine";
            this.agentMachineName.Name = "agentMachineName";
            this.agentMachineName.ReadOnly = true;
            this.agentMachineName.Width = 150;
            // 
            // agentIP
            // 
            this.agentIP.HeaderText = "IP";
            this.agentIP.Name = "agentIP";
            this.agentIP.ReadOnly = true;
            this.agentIP.Width = 150;
            // 
            // agentServiceName
            // 
            this.agentServiceName.HeaderText = "Service";
            this.agentServiceName.Name = "agentServiceName";
            this.agentServiceName.ReadOnly = true;
            this.agentServiceName.Width = 150;
            // 
            // btnRestartAll
            // 
            this.btnRestartAll.BackColor = System.Drawing.Color.LightGray;
            this.btnRestartAll.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartAll.ForeColor = System.Drawing.Color.Black;
            this.btnRestartAll.Location = new System.Drawing.Point(407, 290);
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
            this.dataGridViewLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewLogs.ColumnHeadersHeight = 26;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Type,
            this.MachineName,
            this.IP,
            this.ServiceName,
            this.Information,
            this.Elapsed});
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
            this.Type.Width = 75;
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
            this.ServiceName.Width = 110;
            // 
            // Information
            // 
            this.Information.HeaderText = "Information";
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.Width = 230;
            // 
            // Elapsed
            // 
            this.Elapsed.HeaderText = "Elapsed";
            this.Elapsed.Name = "Elapsed";
            this.Elapsed.ReadOnly = true;
            this.Elapsed.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(941, 529);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.btnRestartAll);
            this.Controls.Add(this.dataGridViewServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Techsupport Restarter Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button btnRestartAll;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Information;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elapsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}