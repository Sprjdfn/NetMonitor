using System;
using System.Threading;
using System.Windows.Forms;

namespace NetMonitor
{
	public partial class settingForm : Form
	{
		public settingForm()
		{
			InitializeComponent();
		}

		private void settingForm_Load(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Appearance.Default.Language);
			themeChoosing1.target = (MainForm)Owner;
		}
	}
}
