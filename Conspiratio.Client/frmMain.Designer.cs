namespace Conspiratio.Client
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
            this.btnVerbinden = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.grpServer = new System.Windows.Forms.GroupBox();
            this.btnTrennen = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtServerlog = new System.Windows.Forms.TextBox();
            this.txtNachricht = new System.Windows.Forms.TextBox();
            this.lblNachricht = new System.Windows.Forms.Label();
            this.btnSenden = new System.Windows.Forms.Button();
            this.lblChat = new System.Windows.Forms.Label();
            this.grpServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerbinden
            // 
            this.btnVerbinden.Location = new System.Drawing.Point(19, 113);
            this.btnVerbinden.Name = "btnVerbinden";
            this.btnVerbinden.Size = new System.Drawing.Size(90, 23);
            this.btnVerbinden.TabIndex = 0;
            this.btnVerbinden.Text = "Verbinden";
            this.btnVerbinden.UseVisualStyleBackColor = true;
            this.btnVerbinden.Click += new System.EventHandler(this.btnVerbinden_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(16, 27);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            // 
            // grpServer
            // 
            this.grpServer.Controls.Add(this.btnTrennen);
            this.grpServer.Controls.Add(this.lblUsername);
            this.grpServer.Controls.Add(this.txtUsername);
            this.grpServer.Controls.Add(this.txtPort);
            this.grpServer.Controls.Add(this.txtServer);
            this.grpServer.Controls.Add(this.lblPort);
            this.grpServer.Controls.Add(this.lblServer);
            this.grpServer.Controls.Add(this.btnVerbinden);
            this.grpServer.Location = new System.Drawing.Point(12, 12);
            this.grpServer.Name = "grpServer";
            this.grpServer.Size = new System.Drawing.Size(255, 147);
            this.grpServer.TabIndex = 2;
            this.grpServer.TabStop = false;
            this.grpServer.Text = "Anmeldung";
            // 
            // btnTrennen
            // 
            this.btnTrennen.Enabled = false;
            this.btnTrennen.Location = new System.Drawing.Point(146, 113);
            this.btnTrennen.Name = "btnTrennen";
            this.btnTrennen.Size = new System.Drawing.Size(90, 23);
            this.btnTrennen.TabIndex = 7;
            this.btnTrennen.Text = "Trennen";
            this.btnTrennen.UseVisualStyleBackColor = true;
            this.btnTrennen.Click += new System.EventHandler(this.btnTrennen_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 79);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(79, 50);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(157, 20);
            this.txtPort.TabIndex = 4;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(79, 24);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(157, 20);
            this.txtServer.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(16, 53);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtChat
            // 
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.Location = new System.Drawing.Point(12, 179);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(709, 324);
            this.txtChat.TabIndex = 3;
            // 
            // txtServerlog
            // 
            this.txtServerlog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerlog.Location = new System.Drawing.Point(282, 12);
            this.txtServerlog.Multiline = true;
            this.txtServerlog.Name = "txtServerlog";
            this.txtServerlog.ReadOnly = true;
            this.txtServerlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServerlog.Size = new System.Drawing.Size(439, 147);
            this.txtServerlog.TabIndex = 4;
            // 
            // txtNachricht
            // 
            this.txtNachricht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachricht.Location = new System.Drawing.Point(81, 507);
            this.txtNachricht.Multiline = true;
            this.txtNachricht.Name = "txtNachricht";
            this.txtNachricht.Size = new System.Drawing.Size(559, 44);
            this.txtNachricht.TabIndex = 6;
            // 
            // lblNachricht
            // 
            this.lblNachricht.AutoSize = true;
            this.lblNachricht.Location = new System.Drawing.Point(12, 517);
            this.lblNachricht.Name = "lblNachricht";
            this.lblNachricht.Size = new System.Drawing.Size(53, 13);
            this.lblNachricht.TabIndex = 7;
            this.lblNachricht.Text = "Nachricht";
            // 
            // btnSenden
            // 
            this.btnSenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSenden.Enabled = false;
            this.btnSenden.Location = new System.Drawing.Point(646, 507);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 44);
            this.btnSenden.TabIndex = 8;
            this.btnSenden.Text = "Senden";
            this.btnSenden.UseVisualStyleBackColor = true;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Location = new System.Drawing.Point(19, 162);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(29, 13);
            this.lblChat.TabIndex = 9;
            this.lblChat.Text = "Chat";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 556);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.btnSenden);
            this.Controls.Add(this.lblNachricht);
            this.Controls.Add(this.txtNachricht);
            this.Controls.Add(this.txtServerlog);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.grpServer);
            this.Name = "frmMain";
            this.Text = "Conspiratio Client";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpServer.ResumeLayout(false);
            this.grpServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerbinden;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.GroupBox grpServer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnTrennen;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtServerlog;
        private System.Windows.Forms.TextBox txtNachricht;
        private System.Windows.Forms.Label lblNachricht;
        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.Label lblChat;
    }
}

