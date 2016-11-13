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
			this.netChoosing1 = new NetMonitor.NetChoosing();
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
			// netChoosing1
			// 
			this.netChoosing1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.netChoosing1.Location = new System.Drawing.Point(0, 0);
			this.netChoosing1.Name = "netChoosing1";
			this.netChoosing1.Size = new System.Drawing.Size(861, 475);
			this.netChoosing1.TabIndex = 2;
			// 
			// settingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 475);
			this.Controls.Add(this.netChoosing1);
			this.Controls.Add(this.nTabControl1);
			this.Name = "settingForm";
			this.Text = "settingForm";
			this.ResumeLayout(false);

		}

		#endregion

		private Nevron.Nov.WinFormControls.NTabControl nTabControl1;
		private NetChoosing netChoosing1;
	}
}