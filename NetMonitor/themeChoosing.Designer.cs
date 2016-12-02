namespace NetMonitor
{
	partial class themeChoosing
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themeChoosing));
			this.themeImageList = new System.Windows.Forms.ImageList(this.components);
			this.themeList = new System.Windows.Forms.ListView();
			this.themeChooseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// themeImageList
			// 
			this.themeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			resources.ApplyResources(this.themeImageList, "themeImageList");
			this.themeImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// themeList
			// 
			resources.ApplyResources(this.themeList, "themeList");
			this.themeList.LargeImageList = this.themeImageList;
			this.themeList.Name = "themeList";
			this.themeList.UseCompatibleStateImageBehavior = false;
			// 
			// themeChooseButton
			// 
			resources.ApplyResources(this.themeChooseButton, "themeChooseButton");
			this.themeChooseButton.Name = "themeChooseButton";
			this.themeChooseButton.UseVisualStyleBackColor = true;
			this.themeChooseButton.Click += new System.EventHandler(this.themeChooseButton_Click);
			// 
			// themeChoosing
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.themeChooseButton);
			this.Controls.Add(this.themeList);
			this.Name = "themeChoosing";
			this.Load += new System.EventHandler(this.themeChoosing_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList themeImageList;
		private System.Windows.Forms.ListView themeList;
		private System.Windows.Forms.Button themeChooseButton;
	}
}
