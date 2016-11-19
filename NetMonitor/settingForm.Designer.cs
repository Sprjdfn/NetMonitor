namespace NetMonitor
{
	partial class settingForm
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
			this.nTabControl1 = new Nevron.Nov.WinFormControls.NTabControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.choosePage = new System.Windows.Forms.TabPage();
			this.netChoosing1 = new NetMonitor.NetChoosing();
			this.appearancePage = new System.Windows.Forms.TabPage();
			this.themeChoosing1 = new NetMonitor.themeChoosing();
			this.tabControl1.SuspendLayout();
			this.choosePage.SuspendLayout();
			this.appearancePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// nTabControl1
			// 
			this.nTabControl1.AutoSize = false;
			this.nTabControl1.DesignTimeState = null;
			this.nTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nTabControl1.Location = new System.Drawing.Point(0, 0);
			this.nTabControl1.Name = "nTabControl1";
			this.nTabControl1.Size = new System.Drawing.Size(861, 475);
			this.nTabControl1.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.choosePage);
			this.tabControl1.Controls.Add(this.appearancePage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(861, 475);
			this.tabControl1.TabIndex = 3;
			// 
			// choosePage
			// 
			this.choosePage.Controls.Add(this.netChoosing1);
			this.choosePage.Location = new System.Drawing.Point(4, 25);
			this.choosePage.Name = "choosePage";
			this.choosePage.Padding = new System.Windows.Forms.Padding(3);
			this.choosePage.Size = new System.Drawing.Size(853, 446);
			this.choosePage.TabIndex = 0;
			this.choosePage.Text = "选择网络";
			this.choosePage.UseVisualStyleBackColor = true;
			// 
			// netChoosing1
			// 
			this.netChoosing1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.netChoosing1.Location = new System.Drawing.Point(3, 3);
			this.netChoosing1.Name = "netChoosing1";
			this.netChoosing1.Size = new System.Drawing.Size(847, 440);
			this.netChoosing1.TabIndex = 2;
			// 
			// appearancePage
			// 
			this.appearancePage.Controls.Add(this.themeChoosing1);
			this.appearancePage.Location = new System.Drawing.Point(4, 25);
			this.appearancePage.Name = "appearancePage";
			this.appearancePage.Padding = new System.Windows.Forms.Padding(3);
			this.appearancePage.Size = new System.Drawing.Size(853, 446);
			this.appearancePage.TabIndex = 1;
			this.appearancePage.Text = "外观";
			this.appearancePage.UseVisualStyleBackColor = true;
			// 
			// themeChoosing1
			// 
			this.themeChoosing1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.themeChoosing1.Location = new System.Drawing.Point(3, 3);
			this.themeChoosing1.Name = "themeChoosing1";
			this.themeChoosing1.Size = new System.Drawing.Size(847, 440);
			this.themeChoosing1.TabIndex = 0;
			// 
			// settingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 475);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.nTabControl1);
			this.Name = "settingForm";
			this.Text = "设置";
			this.Load += new System.EventHandler(this.settingForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.choosePage.ResumeLayout(false);
			this.appearancePage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Nevron.Nov.WinFormControls.NTabControl nTabControl1;
		private NetChoosing netChoosing1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage choosePage;
		private System.Windows.Forms.TabPage appearancePage;
		private themeChoosing themeChoosing1;
	}
}