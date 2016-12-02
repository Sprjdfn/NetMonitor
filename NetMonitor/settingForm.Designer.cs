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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingForm));
			this.nTabControl1 = new Nevron.Nov.WinFormControls.NTabControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.choosePage = new System.Windows.Forms.TabPage();
			this.netChoosing1 = new NetMonitor.NetChoosing();
			this.themePage = new System.Windows.Forms.TabPage();
			this.themeChoosing1 = new NetMonitor.themeChoosing();
			this.tabControl1.SuspendLayout();
			this.choosePage.SuspendLayout();
			this.themePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// nTabControl1
			// 
			resources.ApplyResources(this.nTabControl1, "nTabControl1");
			this.nTabControl1.DesignTimeState = null;
			this.nTabControl1.Name = "nTabControl1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.choosePage);
			this.tabControl1.Controls.Add(this.themePage);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// choosePage
			// 
			this.choosePage.Controls.Add(this.netChoosing1);
			resources.ApplyResources(this.choosePage, "choosePage");
			this.choosePage.Name = "choosePage";
			this.choosePage.UseVisualStyleBackColor = true;
			// 
			// netChoosing1
			// 
			resources.ApplyResources(this.netChoosing1, "netChoosing1");
			this.netChoosing1.Name = "netChoosing1";
			// 
			// themePage
			// 
			this.themePage.Controls.Add(this.themeChoosing1);
			resources.ApplyResources(this.themePage, "themePage");
			this.themePage.Name = "themePage";
			this.themePage.UseVisualStyleBackColor = true;
			// 
			// themeChoosing1
			// 
			resources.ApplyResources(this.themeChoosing1, "themeChoosing1");
			this.themeChoosing1.Name = "themeChoosing1";
			// 
			// settingForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.nTabControl1);
			this.Name = "settingForm";
			this.Load += new System.EventHandler(this.settingForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.choosePage.ResumeLayout(false);
			this.themePage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Nevron.Nov.WinFormControls.NTabControl nTabControl1;
		private NetChoosing netChoosing1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage choosePage;
		private System.Windows.Forms.TabPage themePage;
		private themeChoosing themeChoosing1;
	}
}