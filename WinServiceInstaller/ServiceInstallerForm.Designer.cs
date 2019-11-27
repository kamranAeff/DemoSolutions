namespace WinServiceInstaller
{
    partial class ServiceInstallerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceInstallerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFrameworkPath = new System.Windows.Forms.Button();
            this.txtFrameworkPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnServicePath = new System.Windows.Forms.Button();
            this.txtServicePath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBox1.Controls.Add(this.btnFrameworkPath);
            this.groupBox1.Controls.Add(this.txtFrameworkPath);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(722, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Framework Folder";
            // 
            // btnFrameworkPath
            // 
            this.btnFrameworkPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrameworkPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnFrameworkPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrameworkPath.FlatAppearance.BorderSize = 0;
            this.btnFrameworkPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrameworkPath.Location = new System.Drawing.Point(682, 24);
            this.btnFrameworkPath.Name = "btnFrameworkPath";
            this.btnFrameworkPath.Size = new System.Drawing.Size(33, 26);
            this.btnFrameworkPath.TabIndex = 1;
            this.btnFrameworkPath.Text = "...";
            this.btnFrameworkPath.UseVisualStyleBackColor = false;
            this.btnFrameworkPath.Click += new System.EventHandler(this.btnFrameworkPath_Click);
            this.btnFrameworkPath.MouseEnter += new System.EventHandler(this.btnInstall_MouseEnter);
            this.btnFrameworkPath.MouseLeave += new System.EventHandler(this.btnInstall_MouseLeave);
            // 
            // txtFrameworkPath
            // 
            this.txtFrameworkPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrameworkPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtFrameworkPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtFrameworkPath.Location = new System.Drawing.Point(9, 24);
            this.txtFrameworkPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrameworkPath.Name = "txtFrameworkPath";
            this.txtFrameworkPath.ReadOnly = true;
            this.txtFrameworkPath.Size = new System.Drawing.Size(672, 26);
            this.txtFrameworkPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnServicePath);
            this.groupBox2.Controls.Add(this.txtServicePath);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox2.Location = new System.Drawing.Point(9, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(722, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service Path";
            // 
            // btnServicePath
            // 
            this.btnServicePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServicePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnServicePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicePath.FlatAppearance.BorderSize = 0;
            this.btnServicePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicePath.Location = new System.Drawing.Point(682, 24);
            this.btnServicePath.Name = "btnServicePath";
            this.btnServicePath.Size = new System.Drawing.Size(33, 26);
            this.btnServicePath.TabIndex = 1;
            this.btnServicePath.Text = "...";
            this.btnServicePath.UseVisualStyleBackColor = false;
            this.btnServicePath.Click += new System.EventHandler(this.btnServicePath_Click);
            this.btnServicePath.MouseEnter += new System.EventHandler(this.btnInstall_MouseEnter);
            this.btnServicePath.MouseLeave += new System.EventHandler(this.btnInstall_MouseLeave);
            // 
            // txtServicePath
            // 
            this.txtServicePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServicePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtServicePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtServicePath.Location = new System.Drawing.Point(9, 24);
            this.txtServicePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicePath.Name = "txtServicePath";
            this.txtServicePath.ReadOnly = true;
            this.txtServicePath.Size = new System.Drawing.Size(672, 26);
            this.txtServicePath.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnInstall);
            this.panel1.Controls.Add(this.btnUninstall);
            this.panel1.Location = new System.Drawing.Point(9, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 53);
            this.panel1.TabIndex = 1;
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnInstall.Location = new System.Drawing.Point(531, 3);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(93, 46);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            this.btnInstall.MouseEnter += new System.EventHandler(this.btnInstall_MouseEnter);
            this.btnInstall.MouseLeave += new System.EventHandler(this.btnInstall_MouseLeave);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUninstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUninstall.FlatAppearance.BorderSize = 0;
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnUninstall.Location = new System.Drawing.Point(626, 3);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(93, 46);
            this.btnUninstall.TabIndex = 0;
            this.btnUninstall.Text = "Unistall";
            this.btnUninstall.UseVisualStyleBackColor = false;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            this.btnUninstall.MouseEnter += new System.EventHandler(this.btnInstall_MouseEnter);
            this.btnUninstall.MouseLeave += new System.EventHandler(this.btnInstall_MouseLeave);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(9, 206);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(722, 364);
            this.txtLog.TabIndex = 2;
            // 
            // ofDialog
            // 
            this.ofDialog.Filter = "Windows Service (*.exe)|*.exe";
            this.ofDialog.Title = "Servisi seçin";
            // 
            // fbDialog
            // 
            this.fbDialog.Description = "Framework ünvanını seçin";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ServiceInstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(741, 582);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceInstallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFrameworkPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServicePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnFrameworkPath;
        private System.Windows.Forms.Button btnServicePath;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

