using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nevron.Nov.UI;
using Echevil;
using Nevron.Nov.Graphics;
using System.Threading;

namespace NetMonitor
{
	public partial class NetChoosing : UserControl
	{
		public NetChoosing()
		{
			InitializeComponent();
		}

		private NetworkMonitor monitor = new NetworkMonitor();

		private string getSpeed(long speed)
		{
			if (speed < 1024)
				return speed.ToString() + "Byte";
			if (speed < 1048576)
				return (speed / 1024.0).ToString("F2") + "KB";
			return (speed / 1048576.0).ToString("F2") + "MB";
		}

		private void NetChoosing_Load(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Appearance.Default.Language);
			monitor.StartMonitoring();
			foreach (NetworkAdapter tmp in monitor.Adapters)
			{
				ListViewItem item = new ListViewItem();
				item.Name = tmp.Name;
				item.Text = tmp.Name;
				ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
				sub1.Text = tmp.Name;
				sub1.Name = "name";
				item.SubItems.Add(sub1);
				ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
				sub2.Text = getSpeed(tmp.UploadSpeed);
				sub2.Name = "upload";
				item.SubItems.Add(sub2);
				ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem();
				sub3.Text = getSpeed(tmp.UploadSpeed);
				sub3.Name = "upload";
				item.SubItems.Add(sub3);
				listBox.Items.Add(item);
			}
		}
		

		private void flushTimer_Tick(object sender, EventArgs e)
		{
			foreach (ListViewItem tmp in listBox.Items)
			{
				foreach (NetworkAdapter tmpAdapter in monitor.Adapters)
				{
					if (tmp.Name == tmpAdapter.Name)
					{
						tmp.SubItems[1].Text = getSpeed(tmpAdapter.UploadSpeed);
						tmp.SubItems[2].Text = getSpeed(tmpAdapter.DownloadSpeed);
					}
				}
			}
		}

		private void reflushButton_Click(object sender, EventArgs e)
		{
			listBox.Items.Clear();
			foreach (NetworkAdapter tmp in monitor.Adapters)
			{
				ListViewItem item = new ListViewItem();
				item.Name = tmp.Name;
				ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem();
				sub1.Text = Name;
				sub1.Name = "name";
				item.SubItems.Add(sub1);
				ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem();
				sub2.Text = getSpeed(tmp.UploadSpeed);
				sub2.Name = "upload";
				item.SubItems.Add(sub2);
				ListViewItem.ListViewSubItem sub3 = new ListViewItem.ListViewSubItem();
				sub3.Text = getSpeed(tmp.UploadSpeed);
				sub3.Name = "upload";
				item.SubItems.Add(sub3);
				listBox.Items.Add(item);
			}
		}

		private void netChooseButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.NetAdapter = listBox.SelectedItems[0].Name;
			Properties.Settings.Default.Save();
		}
	}
}
