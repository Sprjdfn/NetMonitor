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

namespace NetMonitor
{
	public partial class NetChoosing : UserControl
	{
		public NetChoosing()
		{
			InitializeComponent();
		}

		private NetworkMonitor monitor = new NetworkMonitor();

		private void NetChoosing_Load(object sender, EventArgs e)
		{
			monitor.StartMonitoring();
			foreach (NetworkAdapter tmp in monitor.Adapters)
			{
				NStackPanel newPanel = new NStackPanel();
				newPanel.Padding = new Nevron.Nov.Graphics.NMargins(3);
				NLabel tmpLabel1 = new NLabel(tmp.Name);
				NImageBox tmpImage1 = new NImageBox();
				tmpImage1.Image = NImage.FromFile(Application.StartupPath + "/Image/network.png");
				NPairBox pairBox1 = new NPairBox(tmpImage1, tmpLabel1);
				pairBox1.Spacing = 3;
				newPanel.Add(pairBox1);
				NLabel tmpLabel2 = new NLabel(tmp.UploadSpeed.ToString());
				NImageBox tmpImage2 = new NImageBox();
				tmpImage2.Image = NImage.FromFile(Application.StartupPath + "/Image/upload.png");
				NPairBox pairBox2 = new NPairBox(tmpImage2, tmpLabel2);
				pairBox2.Spacing = 3;
				newPanel.Add(pairBox2);
				NLabel tmpLabel3 = new NLabel(tmp.DownloadSpeed.ToString());
				NImageBox tmpImage3 = new NImageBox();
				tmpImage3.Image = NImage.FromFile(Application.StartupPath + "/Image/download.png");
				NPairBox pairBox3 = new NPairBox(tmpImage3, tmpLabel3);
				pairBox3.Spacing = 3;
				newPanel.Add(pairBox3);
				NListBoxItem newItem = new NListBoxItem(newPanel);
				listBox.Widget.Items.Add(newItem);
			}
			((NButton)nPairBoxControl1.Widget.Box1).Click += applyButton_Click;
		}

		private void flushButton_Click(Nevron.Nov.Dom.NEventArgs arg)
		{
			listBox.Widget.Items.Clear();
			foreach (NetworkAdapter tmp in monitor.Adapters)
			{
				NStackPanel newPanel = new NStackPanel();
				newPanel.Padding = new Nevron.Nov.Graphics.NMargins(3);
				NLabel tmpLabel1 = new NLabel(tmp.Name);
				NImageBox tmpImage1 = new NImageBox();
				tmpImage1.Image = NImage.FromFile(Application.StartupPath + "/Image/network.png");
				NPairBox pairBox1 = new NPairBox(tmpImage1, tmpLabel1);
				pairBox1.Spacing = 3;
				newPanel.Add(pairBox1);
				NLabel tmpLabel2 = new NLabel(tmp.UploadSpeed.ToString());
				NImageBox tmpImage2 = new NImageBox();
				tmpImage2.Image = NImage.FromFile(Application.StartupPath + "/Image/upload.png");
				NPairBox pairBox2 = new NPairBox(tmpImage2, tmpLabel2);
				pairBox2.Spacing = 3;
				newPanel.Add(pairBox2);
				NLabel tmpLabel3 = new NLabel(tmp.DownloadSpeed.ToString());
				NImageBox tmpImage3 = new NImageBox();
				tmpImage3.Image = NImage.FromFile(Application.StartupPath + "/Image/download.png");
				NPairBox pairBox3 = new NPairBox(tmpImage3, tmpLabel3);
				pairBox3.Spacing = 3;
				newPanel.Add(pairBox3);
				NListBoxItem newItem = new NListBoxItem(newPanel);
				listBox.Widget.Items.Add(newItem);
			}
		}

		private void flushTimer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < listBox.Widget.Items.Count; i++)
			{
				NListBoxItem tmp = listBox.Widget.Items[i];
				foreach (NetworkAdapter tmpAdapter in monitor.Adapters)
				{
					if (((NLabel)((NPairBox)((NStackPanel)tmp.GetFirstChild()).GetChildAt(0)).Box2).Text == tmpAdapter.Name)
					{
						((NLabel)((NPairBox)((NStackPanel)tmp.GetFirstChild()).GetChildAt(1)).Box2).Text = tmpAdapter.UploadSpeed.ToString();
						((NLabel)((NPairBox)((NStackPanel)tmp.GetFirstChild()).GetChildAt(2)).Box2).Text = tmpAdapter.DownloadSpeed.ToString();
					}
				}
			}
		}

		private void applyButton_Click(Nevron.Nov.Dom.NEventArgs arg)
		{
			Properties.Settings.Default.NetAdapter = ((NLabel)((NPairBox)((NStackPanel)listBox.Widget.Selection.SelectedItems[0].GetFirstChild()).GetChildAt(0)).Box2).Text;
			Properties.Settings.Default.Save();
		}

		private void cancelButton_Click(Nevron.Nov.Dom.NEventArgs arg)
		{
			flushButton_Click(arg);
		}
	}
}
