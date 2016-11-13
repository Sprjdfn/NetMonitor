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
			this.listBox = new Nevron.Nov.WinFormControls.NListBoxControl();
			this.ReflushButton = new Nevron.Nov.WinFormControls.NButtonControl();
			this.flushTimer = new System.Windows.Forms.Timer(this.components);
			this.nPairBoxControl1 = new Nevron.Nov.WinFormControls.NPairBoxControl();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox.AutoSize = false;
			this.listBox.DesignTimeState = null;
			this.listBox.Location = new System.Drawing.Point(0, 23);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(404, 412);
			this.listBox.TabIndex = 0;
			// 
			// ReflushButton
			// 
			this.ReflushButton.AutoSize = false;
			this.ReflushButton.DesignTimeState = resources.GetString("ReflushButton.DesignTimeState");
			this.ReflushButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ReflushButton.Location = new System.Drawing.Point(0, 0);
			this.ReflushButton.Name = "ReflushButton";
			this.ReflushButton.Size = new System.Drawing.Size(404, 23);
			this.ReflushButton.TabIndex = 1;
			this.ReflushButton.Click += new Nevron.Nov.Function<Nevron.Nov.Dom.NEventArgs>(this.flushButton_Click);
			// 
			// flushTimer
			// 
			this.flushTimer.Enabled = true;
			this.flushTimer.Tick += new System.EventHandler(this.flushTimer_Tick);
			// 
			// nPairBoxControl1
			// 
			this.nPairBoxControl1.AutoSize = false;
			this.nPairBoxControl1.DesignTimeState = resources.GetString("nPairBoxControl1.DesignTimeState");
			this.nPairBoxControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.nPairBoxControl1.Location = new System.Drawing.Point(0, 436);
			this.nPairBoxControl1.Name = "nPairBoxControl1";
			this.nPairBoxControl1.Size = new System.Drawing.Size(404, 23);
			this.nPairBoxControl1.TabIndex = 2;
			// 
			// NetChoosing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nPairBoxControl1);
			this.Controls.Add(this.ReflushButton);
			this.Controls.Add(this.listBox);
			this.Name = "NetChoosing";
			this.Size = new System.Drawing.Size(404, 459);
			this.Load += new System.EventHandler(this.NetChoosing_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Nevron.Nov.WinFormControls.NListBoxControl listBox;
		private Nevron.Nov.WinFormControls.NButtonControl ReflushButton;
		private System.Windows.Forms.Timer flushTimer;
		private Nevron.Nov.WinFormControls.NPairBoxControl nPairBoxControl1;
	}
}
