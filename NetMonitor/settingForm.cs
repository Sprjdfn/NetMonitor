using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			themeChoosing1.target = (Form1)Owner;
		}
	}
}
