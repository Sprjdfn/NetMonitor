namespace NetMonitor
{
	partial class GeneralPage
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralPage));
			this.languageGroupBox = new System.Windows.Forms.GroupBox();
			this.langApplyButton = new System.Windows.Forms.Button();
			this.languageBox = new System.Windows.Forms.ComboBox();
			this.languageGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// languageGroupBox
			// 
			this.languageGroupBox.Controls.Add(this.langApplyButton);
			this.languageGroupBox.Controls.Add(this.languageBox);
			resources.ApplyResources(this.languageGroupBox, "languageGroupBox");
			this.languageGroupBox.Name = "languageGroupBox";
			this.languageGroupBox.TabStop = false;
			// 
			// langApplyButton
			// 
			resources.ApplyResources(this.langApplyButton, "langApplyButton");
			this.langApplyButton.Name = "langApplyButton";
			this.langApplyButton.UseVisualStyleBackColor = true;
			this.langApplyButton.Click += new System.EventHandler(this.langApplyButton_Click);
			// 
			// languageBox
			// 
			this.languageBox.FormattingEnabled = true;
			resources.ApplyResources(this.languageBox, "languageBox");
			this.languageBox.Name = "languageBox";
			// 
			// GeneralPage
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.languageGroupBox);
			this.Name = "GeneralPage";
			this.Load += new System.EventHandler(this.GeneralPage_Load);
			this.languageGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox languageGroupBox;
		private System.Windows.Forms.ComboBox languageBox;
		private System.Windows.Forms.Button langApplyButton;
	}
}
