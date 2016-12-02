using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetMonitor
{
	public partial class themeChoosing : UserControl
	{
		public themeChoosing()
		{
			InitializeComponent();
		}

		public MainForm target;

		private void themeChoosing_Load(object sender, EventArgs e)
		{
			string theme = Properties.theme.themeList;
			string[] allTheme = theme.Split(';');
			themeList.BeginUpdate();
			themeImageList.Images.Clear();
			themeList.Items.Clear();
			themeList.View = View.LargeIcon;
			int cnt = 0;
			foreach (string tmp in allTheme)
			{
				themeImageList.Images.Add(Properties.theme.ResourceManager.GetObject(tmp) as Image);
				ListViewItem newItem = new ListViewItem();
				newItem.ImageIndex = cnt;
				newItem.Text = tmp;
				newItem.Name = tmp;
				cnt++;
				themeList.Items.Add(newItem);
			}
			themeList.EndUpdate();
		}

		private void themeChooseButton_Click(object sender, EventArgs e)
		{
			Properties.Appearance.Default.theme = themeList.SelectedItems[0].Name;
			Properties.Appearance.Default.Save();
			target.reflushUI();
		}
	}
}
