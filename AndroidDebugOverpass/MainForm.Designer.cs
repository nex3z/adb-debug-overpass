namespace AndroidDebugOverpass
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
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.txtDeviceIp = new System.Windows.Forms.TextBox();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInstall = new System.Windows.Forms.Button();
            this.txtApkPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 12;
            this.lstDevices.Location = new System.Drawing.Point(12, 39);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(202, 232);
            this.lstDevices.TabIndex = 0;
            // 
            // txtDeviceIp
            // 
            this.txtDeviceIp.Location = new System.Drawing.Point(12, 12);
            this.txtDeviceIp.Name = "txtDeviceIp";
            this.txtDeviceIp.Size = new System.Drawing.Size(144, 21);
            this.txtDeviceIp.TabIndex = 1;
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tabPage1);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Location = new System.Drawing.Point(220, 10);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(348, 263);
            this.tabContainer.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.btnInstall);
            this.tabPage1.Controls.Add(this.txtApkPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "App";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(259, 5);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // txtApkPath
            // 
            this.txtApkPath.AllowDrop = true;
            this.txtApkPath.Location = new System.Drawing.Point(7, 7);
            this.txtApkPath.Name = "txtApkPath";
            this.txtApkPath.Size = new System.Drawing.Size(246, 21);
            this.txtApkPath.TabIndex = 0;
            this.txtApkPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtApkPath_DragDrop);
            this.txtApkPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtApkPath_DragEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::AndroidDebugOverpass.Properties.Resources.arrow_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(191, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::AndroidDebugOverpass.Properties.Resources.connect;
            this.btnConnect.Location = new System.Drawing.Point(162, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(23, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 285);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDeviceIp);
            this.Controls.Add(this.lstDevices);
            this.Name = "MainForm";
            this.Text = "Adb Debug Overpass";
            this.tabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.TextBox txtDeviceIp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.TextBox txtApkPath;
    }
}

