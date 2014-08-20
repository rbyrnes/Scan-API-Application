namespace Scan_API_Application
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtScanner = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblScanner = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRenewSession = new System.Windows.Forms.Button();
            this.gbxScannerOptions = new System.Windows.Forms.GroupBox();
            this.btnViewScannerSettings = new System.Windows.Forms.Button();
            this.btnCancelChangeServer = new System.Windows.Forms.Button();
            this.btnChangeServer = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnSelectScanner = new System.Windows.Forms.Button();
            this.btnCancelChangePort = new System.Windows.Forms.Button();
            this.btnChangePort = new System.Windows.Forms.Button();
            this.gbxScanningActions = new System.Windows.Forms.GroupBox();
            this.btnGetDocument = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.btnEndScan = new System.Windows.Forms.Button();
            this.gbxOtherOptions = new System.Windows.Forms.GroupBox();
            this.gbxScannerOptions.SuspendLayout();
            this.gbxScanningActions.SuspendLayout();
            this.gbxOtherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScanner
            // 
            this.txtScanner.Enabled = false;
            this.txtScanner.Location = new System.Drawing.Point(168, 39);
            this.txtScanner.Name = "txtScanner";
            this.txtScanner.Size = new System.Drawing.Size(100, 20);
            this.txtScanner.TabIndex = 5;
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(313, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 9;
            // 
            // lblScanner
            // 
            this.lblScanner.AutoSize = true;
            this.lblScanner.Location = new System.Drawing.Point(165, 23);
            this.lblScanner.Name = "lblScanner";
            this.lblScanner.Size = new System.Drawing.Size(50, 13);
            this.lblScanner.TabIndex = 4;
            this.lblScanner.Text = "Scanner:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(310, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port:";
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(32, 18);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(40, 13);
            this.lblStatusText.TabIndex = 0;
            this.lblStatusText.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(78, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "_";
            // 
            // btnRenewSession
            // 
            this.btnRenewSession.Location = new System.Drawing.Point(20, 34);
            this.btnRenewSession.Name = "btnRenewSession";
            this.btnRenewSession.Size = new System.Drawing.Size(100, 26);
            this.btnRenewSession.TabIndex = 0;
            this.btnRenewSession.Text = "Renew Session";
            this.btnRenewSession.UseVisualStyleBackColor = true;
            this.btnRenewSession.Click += new System.EventHandler(this.btnRenewSession_Click);
            // 
            // gbxScannerOptions
            // 
            this.gbxScannerOptions.Controls.Add(this.btnViewScannerSettings);
            this.gbxScannerOptions.Controls.Add(this.btnCancelChangeServer);
            this.gbxScannerOptions.Controls.Add(this.btnChangeServer);
            this.gbxScannerOptions.Controls.Add(this.lblServer);
            this.gbxScannerOptions.Controls.Add(this.txtServer);
            this.gbxScannerOptions.Controls.Add(this.btnSelectScanner);
            this.gbxScannerOptions.Controls.Add(this.btnCancelChangePort);
            this.gbxScannerOptions.Controls.Add(this.btnChangePort);
            this.gbxScannerOptions.Controls.Add(this.lblScanner);
            this.gbxScannerOptions.Controls.Add(this.txtScanner);
            this.gbxScannerOptions.Controls.Add(this.lblPort);
            this.gbxScannerOptions.Controls.Add(this.txtPort);
            this.gbxScannerOptions.Location = new System.Drawing.Point(12, 48);
            this.gbxScannerOptions.Name = "gbxScannerOptions";
            this.gbxScannerOptions.Size = new System.Drawing.Size(439, 199);
            this.gbxScannerOptions.TabIndex = 2;
            this.gbxScannerOptions.TabStop = false;
            this.gbxScannerOptions.Text = "Scanner Options:";
            // 
            // btnViewScannerSettings
            // 
            this.btnViewScannerSettings.Location = new System.Drawing.Point(168, 108);
            this.btnViewScannerSettings.Name = "btnViewScannerSettings";
            this.btnViewScannerSettings.Size = new System.Drawing.Size(100, 38);
            this.btnViewScannerSettings.TabIndex = 7;
            this.btnViewScannerSettings.Text = "View Scanner Settings";
            this.btnViewScannerSettings.UseVisualStyleBackColor = true;
            this.btnViewScannerSettings.Click += new System.EventHandler(this.btnViewScannerSettings_Click);
            // 
            // btnCancelChangeServer
            // 
            this.btnCancelChangeServer.Location = new System.Drawing.Point(23, 107);
            this.btnCancelChangeServer.Name = "btnCancelChangeServer";
            this.btnCancelChangeServer.Size = new System.Drawing.Size(100, 26);
            this.btnCancelChangeServer.TabIndex = 3;
            this.btnCancelChangeServer.Text = "Cancel";
            this.btnCancelChangeServer.UseVisualStyleBackColor = true;
            this.btnCancelChangeServer.Visible = false;
            this.btnCancelChangeServer.Click += new System.EventHandler(this.btnCancelChangeServer_Click);
            // 
            // btnChangeServer
            // 
            this.btnChangeServer.Location = new System.Drawing.Point(23, 75);
            this.btnChangeServer.Name = "btnChangeServer";
            this.btnChangeServer.Size = new System.Drawing.Size(100, 26);
            this.btnChangeServer.TabIndex = 2;
            this.btnChangeServer.Text = "Change Server";
            this.btnChangeServer.UseVisualStyleBackColor = true;
            this.btnChangeServer.Click += new System.EventHandler(this.btnChangeServer_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(20, 23);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(23, 39);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 1;
            // 
            // btnSelectScanner
            // 
            this.btnSelectScanner.Location = new System.Drawing.Point(168, 75);
            this.btnSelectScanner.Name = "btnSelectScanner";
            this.btnSelectScanner.Size = new System.Drawing.Size(100, 26);
            this.btnSelectScanner.TabIndex = 6;
            this.btnSelectScanner.Text = "Select Scanner";
            this.btnSelectScanner.UseVisualStyleBackColor = true;
            this.btnSelectScanner.Click += new System.EventHandler(this.btnSelectScanner_Click);
            // 
            // btnCancelChangePort
            // 
            this.btnCancelChangePort.Location = new System.Drawing.Point(313, 107);
            this.btnCancelChangePort.Name = "btnCancelChangePort";
            this.btnCancelChangePort.Size = new System.Drawing.Size(100, 26);
            this.btnCancelChangePort.TabIndex = 11;
            this.btnCancelChangePort.Text = "Cancel";
            this.btnCancelChangePort.UseVisualStyleBackColor = true;
            this.btnCancelChangePort.Visible = false;
            this.btnCancelChangePort.Click += new System.EventHandler(this.btnCancelChangePort_Click);
            // 
            // btnChangePort
            // 
            this.btnChangePort.Location = new System.Drawing.Point(313, 75);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(100, 26);
            this.btnChangePort.TabIndex = 10;
            this.btnChangePort.Text = "Change Port";
            this.btnChangePort.UseVisualStyleBackColor = true;
            this.btnChangePort.Click += new System.EventHandler(this.btnChangePort_Click);
            // 
            // gbxScanningActions
            // 
            this.gbxScanningActions.Controls.Add(this.btnGetDocument);
            this.gbxScanningActions.Controls.Add(this.btnStartScan);
            this.gbxScanningActions.Controls.Add(this.btnCheckStatus);
            this.gbxScanningActions.Controls.Add(this.btnEndScan);
            this.gbxScanningActions.Location = new System.Drawing.Point(12, 253);
            this.gbxScanningActions.Name = "gbxScanningActions";
            this.gbxScanningActions.Size = new System.Drawing.Size(287, 144);
            this.gbxScanningActions.TabIndex = 3;
            this.gbxScanningActions.TabStop = false;
            this.gbxScanningActions.Text = "Scanning Actions:";
            // 
            // btnGetDocument
            // 
            this.btnGetDocument.Location = new System.Drawing.Point(168, 87);
            this.btnGetDocument.Name = "btnGetDocument";
            this.btnGetDocument.Size = new System.Drawing.Size(100, 38);
            this.btnGetDocument.TabIndex = 3;
            this.btnGetDocument.Text = "Get Document";
            this.btnGetDocument.UseVisualStyleBackColor = true;
            this.btnGetDocument.Click += new System.EventHandler(this.btnGetDocument_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(23, 28);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(100, 38);
            this.btnStartScan.TabIndex = 0;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(23, 87);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(100, 38);
            this.btnCheckStatus.TabIndex = 2;
            this.btnCheckStatus.Text = "Check Scan Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // btnEndScan
            // 
            this.btnEndScan.Location = new System.Drawing.Point(168, 28);
            this.btnEndScan.Name = "btnEndScan";
            this.btnEndScan.Size = new System.Drawing.Size(100, 38);
            this.btnEndScan.TabIndex = 1;
            this.btnEndScan.Text = "End Scan";
            this.btnEndScan.UseVisualStyleBackColor = true;
            this.btnEndScan.Click += new System.EventHandler(this.btnEndScan_Click);
            // 
            // gbxOtherOptions
            // 
            this.gbxOtherOptions.Controls.Add(this.btnRenewSession);
            this.gbxOtherOptions.Location = new System.Drawing.Point(305, 253);
            this.gbxOtherOptions.Name = "gbxOtherOptions";
            this.gbxOtherOptions.Size = new System.Drawing.Size(146, 79);
            this.gbxOtherOptions.TabIndex = 4;
            this.gbxOtherOptions.TabStop = false;
            this.gbxOtherOptions.Text = "Other Options:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 409);
            this.Controls.Add(this.gbxOtherOptions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbxScanningActions);
            this.Controls.Add(this.gbxScannerOptions);
            this.Controls.Add(this.lblStatusText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square 9 Scan API Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbxScannerOptions.ResumeLayout(false);
            this.gbxScannerOptions.PerformLayout();
            this.gbxScanningActions.ResumeLayout(false);
            this.gbxOtherOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScanner;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblScanner;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRenewSession;
        private System.Windows.Forms.GroupBox gbxScannerOptions;
        private System.Windows.Forms.Button btnChangePort;
        private System.Windows.Forms.Button btnCancelChangePort;
        private System.Windows.Forms.Button btnSelectScanner;
        private System.Windows.Forms.Button btnViewScannerSettings;
        private System.Windows.Forms.GroupBox gbxScanningActions;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnEndScan;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Button btnGetDocument;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnCancelChangeServer;
        private System.Windows.Forms.Button btnChangeServer;
        private System.Windows.Forms.GroupBox gbxOtherOptions;

    }
}

