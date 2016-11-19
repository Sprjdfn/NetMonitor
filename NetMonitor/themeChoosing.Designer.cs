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
			this.nButtonControl1 = new Nevron.Nov.WinFormControls.NButtonControl();
			this.SuspendLayout();
			// 
			// themeImageList
			// 
			this.themeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.themeImageList.ImageSize = new System.Drawing.Size(80, 50);
			this.themeImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// themeList
			// 
			this.themeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.themeList.LargeImageList = this.themeImageList;
			this.themeList.Location = new System.Drawing.Point(0, 0);
			this.themeList.Name = "themeList";
			this.themeList.Size = new System.Drawing.Size(550, 482);
			this.themeList.TabIndex = 1;
			this.themeList.UseCompatibleStateImageBehavior = false;
			// 
			// nButtonControl1
			// 
			this.nButtonControl1.AutoSize = false;
			this.nButtonControl1.DesignTimeState = resources.GetString("nButtonControl1.DesignTimeState");
			this.nButtonControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.nButtonControl1.Location = new System.Drawing.Point(0, 481);
			this.nButtonControl1.Name = "nButtonControl1";
			this.nButtonControl1.Size = new System.Drawing.Size(550, 23);
			this.nButtonControl1.TabIndex = 2;
			this.nButtonControl1.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.nButtonControl1_Click);
			// 
			// themeChoosing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nButtonControl1);
			this.Controls.Add(this.themeList);
			this.Name = "themeChoosing";
			this.Size = new System.Drawing.Size(550, 504);
			this.Load += new System.EventHandler(this.themeChoosing_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList themeImageList;
		private System.Windows.Forms.ListView themeList;
		private Nevron.Nov.WinFormControls.NButtonControl nButtonControl1;
	}
}
