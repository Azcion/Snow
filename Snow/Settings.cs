using System;
using System.Windows.Forms;


namespace Snow {

	public partial class Settings : Form {

		public bool saved { get; set; }

		public Settings () {
			InitializeComponent();

			saved = false;
		}

		private void buttonCancel_Click (object sender, EventArgs e) {
			saved = false;
			this.Hide();
		}

		private void buttonSave_Click (object sender, EventArgs e) {
			saved = true;
			this.Hide();
		}
	}
}
