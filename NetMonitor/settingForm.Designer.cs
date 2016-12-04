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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.generalPage = new System.Windows.Forms.TabPage();
			this.generalPage1 = new NetMonitor.GeneralPage();
			this.networkPage = new System.Windows.Forms.TabPage();
			this.netChoosing1 = new NetMonitor.NetChoosing();
			this.themePage = new System.Windows.Forms.TabPage();
			this.themeChoosing1 = new NetMonitor.themeChoosing();
			this.tabControl1.SuspendLayout();
			this.generalPage.SuspendLayout();
			this.networkPage.SuspendLayout();
			this.themePage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.generalPage);
			this.tabControl1.Controls.Add(this.networkPage);
			this.tabControl1.Controls.Add(this.themePage);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// generalPage
			// 
			this.generalPage.Controls.Add(this.generalPage1);
			resources.ApplyResources(this.generalPage, "generalPage");
			this.generalPage.Name = "generalPage";
			this.generalPage.UseVisualStyleBackColor = true;
			// 
			// generalPage1
			// 
			resources.ApplyResources(this.generalPage1, "generalPage1");
			this.generalPage1.Name = "generalPage1";
			// 
			// networkPage
			// 
			this.networkPage.Controls.Add(this.netChoosing1);
			resources.ApplyResources(this.networkPage, "networkPage");
			this.networkPage.Name = "networkPage";
			this.networkPage.UseVisualStyleBackColor = true;
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
			this.Name = "settingForm";
			this.Load += new System.EventHandler(this.settingForm_Load);
			this.Resize += new System.EventHandler(this.settingForm_Resize);
			this.tabControl1.ResumeLayout(false);
			this.generalPage.ResumeLayout(false);
			this.networkPage.ResumeLayout(false);
			this.themePage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private NetChoosing netChoosing1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage networkPage;
		private System.Windows.Forms.TabPage themePage;
		private themeChoosing themeChoosing1;
		private System.Windows.Forms.TabPage generalPage;
		private GeneralPage generalPage1;
	}
}