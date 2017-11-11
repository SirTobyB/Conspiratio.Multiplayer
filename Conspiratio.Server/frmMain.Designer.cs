namespace Conspiratio.Server
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tspMain = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblClients = new System.Windows.Forms.Label();
            this.lsbClients = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.mnuMenue = new System.Windows.Forms.MenuStrip();
            this.btnServer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStarten = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStoppen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProgrammBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tspMain.ContentPanel.SuspendLayout();
            this.tspMain.TopToolStripPanel.SuspendLayout();
            this.tspMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.mnuMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspMain
            // 
            // 
            // tspMain.ContentPanel
            // 
            this.tspMain.ContentPanel.Controls.Add(this.splitContainer1);
            this.tspMain.ContentPanel.Size = new System.Drawing.Size(826, 460);
            this.tspMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspMain.Location = new System.Drawing.Point(0, 0);
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(826, 484);
            this.tspMain.TabIndex = 0;
            this.tspMain.Text = "toolStripContainer1";
            // 
            // tspMain.TopToolStripPanel
            // 
            this.tspMain.TopToolStripPanel.Controls.Add(this.mnuMenue);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblHostname);
            this.splitContainer1.Panel1.Controls.Add(this.txtHostname);
            this.splitContainer1.Panel1.Controls.Add(this.lblPort);
            this.splitContainer1.Panel1.Controls.Add(this.lblServerIP);
            this.splitContainer1.Panel1.Controls.Add(this.txtPort);
            this.splitContainer1.Panel1.Controls.Add(this.txtServerIP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(826, 460);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(6, 14);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(55, 13);
            this.lblHostname.TabIndex = 5;
            this.lblHostname.Text = "Hostname";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(67, 11);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Size = new System.Drawing.Size(206, 20);
            this.txtHostname.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(522, 14);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(288, 14);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(51, 13);
            this.lblServerIP.TabIndex = 2;
            this.lblServerIP.Text = "Server-IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(554, 11);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(79, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "60000";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(345, 11);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.ReadOnly = true;
            this.txtServerIP.Size = new System.Drawing.Size(145, 20);
            this.txtServerIP.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblClients);
            this.splitContainer2.Panel1.Controls.Add(this.lsbClients);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtLog);
            this.splitContainer2.Size = new System.Drawing.Size(826, 418);
            this.splitContainer2.SplitterDistance = 275;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Location = new System.Drawing.Point(3, 9);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(114, 13);
            this.lblClients.TabIndex = 3;
            this.lblClients.Text = "Verbundene Clients (0)";
            // 
            // lsbClients
            // 
            this.lsbClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbClients.FormattingEnabled = true;
            this.lsbClients.Location = new System.Drawing.Point(3, 28);
            this.lsbClients.Name = "lsbClients";
            this.lsbClients.Size = new System.Drawing.Size(270, 381);
            this.lsbClients.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(547, 418);
            this.txtLog.TabIndex = 0;
            // 
            // mnuMenue
            // 
            this.mnuMenue.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnServer});
            this.mnuMenue.Location = new System.Drawing.Point(0, 0);
            this.mnuMenue.Name = "mnuMenue";
            this.mnuMenue.Size = new System.Drawing.Size(826, 24);
            this.mnuMenue.TabIndex = 0;
            this.mnuMenue.Text = "menuStrip1";
            // 
            // btnServer
            // 
            this.btnServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStarten,
            this.btnStoppen,
            this.toolStripSeparator1,
            this.btnProgrammBeenden});
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(51, 20);
            this.btnServer.Text = "Server";
            // 
            // btnStarten
            // 
            this.btnStarten.Name = "btnStarten";
            this.btnStarten.Size = new System.Drawing.Size(180, 22);
            this.btnStarten.Text = "Starten";
            this.btnStarten.Click += new System.EventHandler(this.btnStarten_Click);
            // 
            // btnStoppen
            // 
            this.btnStoppen.Name = "btnStoppen";
            this.btnStoppen.Size = new System.Drawing.Size(180, 22);
            this.btnStoppen.Text = "Stoppen";
            this.btnStoppen.Click += new System.EventHandler(this.btnStoppen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnProgrammBeenden
            // 
            this.btnProgrammBeenden.Name = "btnProgrammBeenden";
            this.btnProgrammBeenden.Size = new System.Drawing.Size(180, 22);
            this.btnProgrammBeenden.Text = "Programm beenden";
            this.btnProgrammBeenden.Click += new System.EventHandler(this.btnProgrammBeenden_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 484);
            this.Controls.Add(this.tspMain);
            this.MainMenuStrip = this.mnuMenue;
            this.Name = "frmMain";
            this.Text = "Conspiratio Server";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tspMain.ContentPanel.ResumeLayout(false);
            this.tspMain.TopToolStripPanel.ResumeLayout(false);
            this.tspMain.TopToolStripPanel.PerformLayout();
            this.tspMain.ResumeLayout(false);
            this.tspMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.mnuMenue.ResumeLayout(false);
            this.mnuMenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tspMain;
        private System.Windows.Forms.MenuStrip mnuMenue;
        private System.Windows.Forms.ToolStripMenuItem btnServer;
        private System.Windows.Forms.ToolStripMenuItem btnStarten;
        private System.Windows.Forms.ToolStripMenuItem btnStoppen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnProgrammBeenden;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.ListBox lsbClients;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox txtHostname;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
    }
}

