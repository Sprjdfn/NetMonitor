namespace NetMonitor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.uploadSpeed = new System.Windows.Forms.Label();
			this.downloadSpeed = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.background = new System.Windows.Forms.PictureBox();
			this.notifyMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
			this.SuspendLayout();
			// 
			// uploadSpeed
			// 
			this.uploadSpeed.AutoSize = true;
			this.uploadSpeed.Location = new System.Drawing.Point(53, 17);
			this.uploadSpeed.Name = "uploadSpeed";
			this.uploadSpeed.Size = new System.Drawing.Size(55, 15);
			this.uploadSpeed.TabIndex = 0;
			this.uploadSpeed.Text = "label1";
			this.uploadSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.uploadSpeed.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			this.uploadSpeed.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
			this.uploadSpeed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.uploadSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			// 
			// downloadSpeed
			// 
			this.downloadSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.downloadSpeed.AutoSize = true;
			this.downloadSpeed.Location = new System.Drawing.Point(53, 53);
			this.downloadSpeed.Name = "downloadSpeed";
			this.downloadSpeed.Size = new System.Drawing.Size(55, 15);
			this.downloadSpeed.TabIndex = 1;
			this.downloadSpeed.Text = "label1";
			this.downloadSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.downloadSpeed.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			this.downloadSpeed.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
			this.downloadSpeed.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.downloadSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipText = "ssss";
			this.notifyIcon1.BalloonTipTitle = "sss";
			this.notifyIcon1.ContextMenuStrip = this.notifyMenuStrip;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "NetMonitor";
			this.notifyIcon1.Visible = true;
			// 
			// notifyMenuStrip
			// 
			this.notifyMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.notifyMenuStrip.Name = "notifyMenuStrip";
			this.notifyMenuStrip.Size = new System.Drawing.Size(138, 56);
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
			this.settingToolStripMenuItem.Text = "Setting";
			this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// background
			// 
			this.background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.background.Location = new System.Drawing.Point(0, 0);
			this.background.Name = "background";
			this.background.Size = new System.Drawing.Size(152, 67);
			this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.background.TabIndex = 2;
			this.background.TabStop = false;
			this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.background.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			this.background.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
			this.background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.background.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(152, 67);
			this.ControlBox = false;
			this.Controls.Add(this.downloadSpeed);
			this.Controls.Add(this.uploadSpeed);
			this.Controls.Add(this.background);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0.5D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			this.notifyMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uploadSpeed;
        private System.Windows.Forms.Label downloadSpeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.PictureBox background;
	}
}

