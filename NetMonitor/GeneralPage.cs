using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace NetMonitor
{
	public partial class GeneralPage : UserControl
	{
		public GeneralPage()
		{
			InitializeComponent();
		}

		private class ComboBoxItem
		{
			public string Name { get; set; }
			public string Text { get; set; }
			public override string ToString()
			{
				return Text;
			}
		}

		private void GeneralPage_Load(object sender, System.EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Appearance.Default.Language);
			ComboBoxItem lang1 = new ComboBoxItem();
			lang1.Text = "English";
			lang1.Name = "en";
			languageBox.Items.Add(lang1);
			ComboBoxItem lang2 = new ComboBoxItem();
			lang2.Text = "简体中文";
			lang2.Name = "zh-CHS";
			languageBox.Items.Add(lang2);
			for (int i = 0; i < languageBox.Items.Count; i++)
			{
				if (((ComboBoxItem)languageBox.Items[i]).Name == Properties.Appearance.Default.Language)
				{
					languageBox.SelectedIndex = i;
				}
			}
		}

		private void langApplyButton_Click(object sender, System.EventArgs e)
		{
			Properties.Appearance.Default.Language = ((ComboBoxItem)languageBox.SelectedItem).Name;
			Properties.Appearance.Default.Save();
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Appearance.Default.Language);
			//MessageBox.Show(new ResourceManager(typeof(GeneralPage)).GetString("changedLanguage"));
		}
	}
}
