namespace NetMonitor
{
	partial class NetChoosing
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetChoosing));
			this.flushTimer = new System.Windows.Forms.Timer(this.components);
			this.reflushButton = new System.Windows.Forms.Button();
			this.netChooseButton = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListView();
			this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.uploadColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.downloadColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// flushTimer
			// 
			this.flushTimer.Enabled = true;
			this.flushTimer.Tick += new System.EventHandler(this.flushTimer_Tick);
			// 
			// reflushButton
			// 
			resources.ApplyResources(this.reflushButton, "reflushButton");
			this.reflushButton.Name = "reflushButton";
			this.reflushButton.UseVisualStyleBackColor = true;
			this.reflushButton.Click += new System.EventHandler(this.reflushButton_Click);
			// 
			// netChooseButton
			// 
			resources.ApplyResources(this.netChooseButton, "netChooseButton");
			this.netChooseButton.Name = "netChooseButton";
			this.netChooseButton.UseVisualStyleBackColor = true;
			this.netChooseButton.Click += new System.EventHandler(this.netChooseButton_Click);
			// 
			// listBox
			// 
			resources.ApplyResources(this.listBox, "listBox");
			this.listBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.uploadColumnHeader,
            this.downloadColumnHeader});
			this.listBox.MultiSelect = false;
			this.listBox.Name = "listBox";
			this.listBox.UseCompatibleStateImageBehavior = false;
			this.listBox.View = System.Windows.Forms.View.Details;
			// 
			// nameColumnHeader
			// 
			resources.ApplyResources(this.nameColumnHeader, "nameColumnHeader");
			// 
			// uploadColumnHeader
			// 
			resources.ApplyResources(this.uploadColumnHeader, "uploadColumnHeader");
			// 
			// downloadColumnHeader
			// 
			resources.ApplyResources(this.downloadColumnHeader, "downloadColumnHeader");
			// 
			// NetChoosing
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.netChooseButton);
			this.Controls.Add(this.reflushButton);
			this.Name = "NetChoosing";
			this.Load += new System.EventHandler(this.NetChoosing_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer flushTimer;
		private System.Windows.Forms.Button reflushButton;
		private System.Windows.Forms.Button netChooseButton;
		private System.Windows.Forms.ListView listBox;
		private System.Windows.Forms.ColumnHeader nameColumnHeader;
		private System.Windows.Forms.ColumnHeader uploadColumnHeader;
		private System.Windows.Forms.ColumnHeader downloadColumnHeader;
	}
}
