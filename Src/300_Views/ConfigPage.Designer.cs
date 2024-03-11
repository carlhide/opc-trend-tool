namespace opc_trend_tool
{
    partial class ConfigPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigPage));
            tcTabs = new TabControl();
            tpConfig = new TabPage();
            gbOpcServerSettings = new GroupBox();
            gbOpcAuthentication = new GroupBox();
            lblOpcUaAuthenticationMethod = new Label();
            gbOpcConnectivity = new GroupBox();
            lblOpcIp = new Label();
            lblOpcUaPort = new Label();
            tpTrending = new TabPage();
            pbBnrLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tcTabs.SuspendLayout();
            tpConfig.SuspendLayout();
            gbOpcServerSettings.SuspendLayout();
            gbOpcAuthentication.SuspendLayout();
            gbOpcConnectivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBnrLogo).BeginInit();
            SuspendLayout();
            // 
            // tcTabs
            // 
            tcTabs.Controls.Add(tpConfig);
            tcTabs.Controls.Add(tpTrending);
            tcTabs.Location = new Point(12, 109);
            tcTabs.Name = "tcTabs";
            tcTabs.SelectedIndex = 0;
            tcTabs.Size = new Size(1181, 534);
            tcTabs.TabIndex = 0;
            // 
            // tpConfig
            // 
            tpConfig.Controls.Add(gbOpcServerSettings);
            tpConfig.Location = new Point(4, 24);
            tpConfig.Name = "tpConfig";
            tpConfig.Padding = new Padding(3);
            tpConfig.Size = new Size(1173, 506);
            tpConfig.TabIndex = 0;
            tpConfig.Text = "Configuration";
            tpConfig.UseVisualStyleBackColor = true;
            // 
            // gbOpcServerSettings
            // 
            gbOpcServerSettings.Controls.Add(gbOpcAuthentication);
            gbOpcServerSettings.Controls.Add(gbOpcConnectivity);
            gbOpcServerSettings.Location = new Point(6, 6);
            gbOpcServerSettings.Name = "gbOpcServerSettings";
            gbOpcServerSettings.Size = new Size(414, 377);
            gbOpcServerSettings.TabIndex = 3;
            gbOpcServerSettings.TabStop = false;
            gbOpcServerSettings.Text = "OPC UA Server Settings";
            // 
            // gbOpcAuthentication
            // 
            gbOpcAuthentication.Controls.Add(label3);
            gbOpcAuthentication.Controls.Add(label2);
            gbOpcAuthentication.Controls.Add(label1);
            gbOpcAuthentication.Controls.Add(lblOpcUaAuthenticationMethod);
            gbOpcAuthentication.Location = new Point(6, 163);
            gbOpcAuthentication.Name = "gbOpcAuthentication";
            gbOpcAuthentication.Size = new Size(402, 208);
            gbOpcAuthentication.TabIndex = 1;
            gbOpcAuthentication.TabStop = false;
            gbOpcAuthentication.Text = "Authentication";
            // 
            // lblOpcUaAuthenticationMethod
            // 
            lblOpcUaAuthenticationMethod.AutoSize = true;
            lblOpcUaAuthenticationMethod.Location = new Point(6, 28);
            lblOpcUaAuthenticationMethod.Name = "lblOpcUaAuthenticationMethod";
            lblOpcUaAuthenticationMethod.Size = new Size(134, 15);
            lblOpcUaAuthenticationMethod.TabIndex = 2;
            lblOpcUaAuthenticationMethod.Text = "Authentication method:";
            // 
            // gbOpcConnectivity
            // 
            gbOpcConnectivity.Controls.Add(lblOpcIp);
            gbOpcConnectivity.Controls.Add(lblOpcUaPort);
            gbOpcConnectivity.Location = new Point(6, 22);
            gbOpcConnectivity.Name = "gbOpcConnectivity";
            gbOpcConnectivity.Size = new Size(402, 135);
            gbOpcConnectivity.TabIndex = 0;
            gbOpcConnectivity.TabStop = false;
            gbOpcConnectivity.Text = "Connectivity";
            // 
            // lblOpcIp
            // 
            lblOpcIp.AutoSize = true;
            lblOpcIp.Location = new Point(6, 33);
            lblOpcIp.Name = "lblOpcIp";
            lblOpcIp.Size = new Size(20, 15);
            lblOpcIp.TabIndex = 0;
            lblOpcIp.Text = "IP:";
            // 
            // lblOpcUaPort
            // 
            lblOpcUaPort.AutoSize = true;
            lblOpcUaPort.Location = new Point(6, 68);
            lblOpcUaPort.Name = "lblOpcUaPort";
            lblOpcUaPort.Size = new Size(32, 15);
            lblOpcUaPort.TabIndex = 1;
            lblOpcUaPort.Text = "Port:";
            // 
            // tpTrending
            // 
            tpTrending.Location = new Point(4, 24);
            tpTrending.Name = "tpTrending";
            tpTrending.Padding = new Padding(3);
            tpTrending.Size = new Size(1173, 506);
            tpTrending.TabIndex = 1;
            tpTrending.Text = "Trend";
            tpTrending.UseVisualStyleBackColor = true;
            // 
            // pbBnrLogo
            // 
            pbBnrLogo.Image = (Image)resources.GetObject("pbBnrLogo.Image");
            pbBnrLogo.Location = new Point(16, 4);
            pbBnrLogo.Name = "pbBnrLogo";
            pbBnrLogo.Size = new Size(136, 99);
            pbBnrLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbBnrLogo.TabIndex = 1;
            pbBnrLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 5);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // ConfigPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1205, 655);
            Controls.Add(pbBnrLogo);
            Controls.Add(tcTabs);
            Name = "ConfigPage";
            Text = "Form1";
            tcTabs.ResumeLayout(false);
            tpConfig.ResumeLayout(false);
            gbOpcServerSettings.ResumeLayout(false);
            gbOpcAuthentication.ResumeLayout(false);
            gbOpcAuthentication.PerformLayout();
            gbOpcConnectivity.ResumeLayout(false);
            gbOpcConnectivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBnrLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcTabs;
        private TabPage tpConfig;
        private TabPage tpTrending;
        private PictureBox pbBnrLogo;
        private Label lblOpcUaPort;
        private Label lblOpcIp;
        private GroupBox gbOpcServerSettings;
        private GroupBox gbOpcConnectivity;
        private Label lblOpcUaAuthenticationMethod;
        private GroupBox gbOpcAuthentication;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
