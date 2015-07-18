using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Snow {

	public partial class Browser : Form {

		private ToolStripMenuItem node;
		private Settings settings;

		public Browser () {
			InitializeComponent();

			settings = new Settings();
			settings.VisibleChanged += new EventHandler(this.Settings_VisibleChanged);

			richUrlBox.SelectionIndent += 3;
			richUrlBox.KeyDown += richUrlBox_KeyDown;

			webBrowser.DocumentTitleChanged += UpdateUrl;

			node = new ToolStripMenuItem();
			node.Text = "Settings";
			node.Click += OpenSettings_Click;

			buttonMenu.DropDownDirection = ToolStripDropDownDirection.BelowLeft;
			buttonMenu.DropDownItems.Add(node);
		}

		private void OpenSettings_Click (object sender, EventArgs e) {
			settings.Show();
		}

		private void Settings_VisibleChanged (object sender, EventArgs e) {
			if (!settings.Visible && settings.saved) {
				settings.saved = false;
				string ipStr = settings.IpBox.Text;
				string portStr = settings.PortBox.Text;
				int port;
				if (!int.TryParse(portStr, out port) || port > 65535) {
					Console.WriteLine("Proxy port invalid: " + portStr);
					return;
				}
				if (!Regex.IsMatch(ipStr, @"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")) {
					Console.WriteLine("IP address invalid: " + ipStr);
				} else {
					WebRequest.DefaultWebProxy = new WebProxy(ipStr, port);

				}
			}
		}

		private void UpdateUrl (object sender, EventArgs e) {
			richUrlBox.Text = webBrowser.Url.ToString();
			titleBox.Text = webBrowser.DocumentTitle;
		}

		private void richUrlBox_KeyDown (object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				webBrowser.Navigate(richUrlBox.Text);
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void bStop_Click (object sender, EventArgs e) {
			webBrowser.Stop();
		}

		private void bHome_Click (object sender, EventArgs e) {
			webBrowser.GoHome();
		}

		private void bBackward_Click (object sender, EventArgs e) {
			webBrowser.GoBack();
		}

		private void bForward_Click (object sender, EventArgs e) {
			webBrowser.GoForward();
		}

		private void bReload_Click (object sender, EventArgs e) {
			webBrowser.Refresh();
		}
	}
}
