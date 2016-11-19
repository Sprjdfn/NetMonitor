using Echevil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetMonitor
{
    public partial class Form1 : Form
    {

        NetworkMonitor monitor = new NetworkMonitor();
        private bool isMouseDown;
        private Point mouseOffset;

        /// <summary>
        /// 按下鼠标事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        /// <summary>
        /// 松开鼠标事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        /// <summary>
        /// 移动窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt-Tab
                return cp;
            }
        }

        public Point FormLocation { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread backGround = new Thread(new ThreadStart(monitor.StartMonitoring));
            backGround.Start();
            Location = new Point(Properties.Appearance.Default.locationX, Properties.Appearance.Default.locationY);
            this.FormBorderStyle = FormBorderStyle.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			uploadSpeed.Text = "Upload:   -";
			downloadSpeed.Text = "Download: -";
			uploadSpeed.Parent = background;
			downloadSpeed.Parent = background;
			uploadSpeed.BackColor = Color.Transparent;
			downloadSpeed.BackColor = Color.Transparent;
			this.TransparencyKey = this.BackColor;
			background.Image = Properties.theme.ResourceManager.GetObject(Properties.Appearance.Default.theme) as Image;
        }

        private string getSpeed(long speed)
        {
            if (speed < 1024)
                return speed.ToString() + "Byte";
            if (speed < 1048576)
                return (speed / 1024).ToString() + "KB";
            return (speed / 1048576).ToString() + "MB";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			foreach (NetworkAdapter tmp in monitor.Adapters)
			{
				if (tmp.Name == Properties.Settings.Default.NetAdapter)
				{
					uploadSpeed.Text = "Upload:   " + getSpeed(tmp.UploadSpeed);
					downloadSpeed.Text = "Download: " + getSpeed(tmp.DownloadSpeed);
				}
			}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Appearance.Default.locationX = Location.X;
            Properties.Appearance.Default.locationY = Location.Y;
            Properties.Appearance.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settingForm setForm = new settingForm();
			setForm.Owner = this;
			setForm.Show();
		}

		public void reflushUI()
		{
			Form1_Load(null, null);
		}
	}
}
