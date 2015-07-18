namespace Snow {

	partial class Browser {

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.bBackward = new System.Windows.Forms.ToolStripButton();
			this.bForward = new System.Windows.Forms.ToolStripButton();
			this.bReload = new System.Windows.Forms.ToolStripButton();
			this.bStop = new System.Windows.Forms.ToolStripButton();
			this.bHome = new System.Windows.Forms.ToolStripButton();
			this.titleBox = new System.Windows.Forms.ToolStripTextBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.richUrlBox = new System.Windows.Forms.RichTextBox();
			this.buttonMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBackward,
            this.bForward,
            this.bReload,
            this.bStop,
            this.bHome,
            this.buttonMenu,
            this.titleBox});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(1084, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// bBackward
			// 
			this.bBackward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bBackward.Image = ((System.Drawing.Image)(resources.GetObject("bBackward.Image")));
			this.bBackward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bBackward.Name = "bBackward";
			this.bBackward.Size = new System.Drawing.Size(23, 22);
			this.bBackward.Text = "buttonBackward";
			this.bBackward.ToolTipText = "Navigate Backward";
			this.bBackward.Click += new System.EventHandler(this.bBackward_Click);
			// 
			// bForward
			// 
			this.bForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bForward.Image = ((System.Drawing.Image)(resources.GetObject("bForward.Image")));
			this.bForward.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bForward.Name = "bForward";
			this.bForward.Size = new System.Drawing.Size(23, 22);
			this.bForward.Text = "buttonForward";
			this.bForward.ToolTipText = "Navigate Forward";
			this.bForward.Click += new System.EventHandler(this.bForward_Click);
			// 
			// bReload
			// 
			this.bReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bReload.Image = ((System.Drawing.Image)(resources.GetObject("bReload.Image")));
			this.bReload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bReload.Name = "bReload";
			this.bReload.Size = new System.Drawing.Size(23, 22);
			this.bReload.Text = "buttonReload";
			this.bReload.ToolTipText = "Reload Page";
			this.bReload.Click += new System.EventHandler(this.bReload_Click);
			// 
			// bStop
			// 
			this.bStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bStop.Image = ((System.Drawing.Image)(resources.GetObject("bStop.Image")));
			this.bStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bStop.Name = "bStop";
			this.bStop.Size = new System.Drawing.Size(23, 22);
			this.bStop.Text = "buttonStop";
			this.bStop.ToolTipText = "Stop";
			this.bStop.Click += new System.EventHandler(this.bStop_Click);
			// 
			// bHome
			// 
			this.bHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bHome.Image = ((System.Drawing.Image)(resources.GetObject("bHome.Image")));
			this.bHome.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.bHome.Name = "bHome";
			this.bHome.Size = new System.Drawing.Size(23, 22);
			this.bHome.Text = "buttonHome";
			this.bHome.ToolTipText = "Home";
			this.bHome.Click += new System.EventHandler(this.bHome_Click);
			// 
			// titleBox
			// 
			this.titleBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.titleBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.titleBox.Name = "titleBox";
			this.titleBox.ReadOnly = true;
			this.titleBox.Size = new System.Drawing.Size(325, 25);
			// 
			// webBrowser
			// 
			this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser.Location = new System.Drawing.Point(0, 28);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(1084, 633);
			this.webBrowser.TabIndex = 1;
			// 
			// richUrlBox
			// 
			this.richUrlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richUrlBox.DetectUrls = false;
			this.richUrlBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richUrlBox.ImeMode = System.Windows.Forms.ImeMode.On;
			this.richUrlBox.Location = new System.Drawing.Point(126, 3);
			this.richUrlBox.MaxLength = 32767;
			this.richUrlBox.Multiline = false;
			this.richUrlBox.Name = "richUrlBox";
			this.richUrlBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richUrlBox.Size = new System.Drawing.Size(606, 19);
			this.richUrlBox.TabIndex = 2;
			this.richUrlBox.Text = "";
			this.richUrlBox.WordWrap = false;
			// 
			// buttonMenu
			// 
			this.buttonMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.buttonMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
			this.buttonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.ShowDropDownArrow = false;
			this.buttonMenu.Size = new System.Drawing.Size(20, 22);
			this.buttonMenu.Text = "Menu";
			// 
			// Snow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 661);
			this.Controls.Add(this.richUrlBox);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.toolStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Snow";
			this.Text = "Snow";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton bBackward;
		private System.Windows.Forms.ToolStripButton bForward;
		private System.Windows.Forms.ToolStripButton bReload;
		private System.Windows.Forms.ToolStripButton bHome;
		private System.Windows.Forms.ToolStripButton bStop;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.ToolStripTextBox titleBox;
		private System.Windows.Forms.RichTextBox richUrlBox;
		private System.Windows.Forms.ToolStripDropDownButton buttonMenu;
	}
}

