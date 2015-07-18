namespace Snow {
	partial class Settings {
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
			this.groupProxy = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.IpBox = new System.Windows.Forms.TextBox();
			this.PortBox = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.groupProxy.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupProxy
			// 
			this.groupProxy.Controls.Add(this.label2);
			this.groupProxy.Controls.Add(this.label1);
			this.groupProxy.Controls.Add(this.IpBox);
			this.groupProxy.Controls.Add(this.PortBox);
			this.groupProxy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupProxy.Location = new System.Drawing.Point(13, 13);
			this.groupProxy.Name = "groupProxy";
			this.groupProxy.Size = new System.Drawing.Size(335, 114);
			this.groupProxy.TabIndex = 0;
			this.groupProxy.TabStop = false;
			this.groupProxy.Text = "Proxy";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(267, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP address";
			// 
			// IpBox
			// 
			this.IpBox.Location = new System.Drawing.Point(11, 69);
			this.IpBox.Name = "IpBox";
			this.IpBox.Size = new System.Drawing.Size(254, 33);
			this.IpBox.TabIndex = 2;
			// 
			// PortBox
			// 
			this.PortBox.Location = new System.Drawing.Point(271, 69);
			this.PortBox.Name = "PortBox";
			this.PortBox.Size = new System.Drawing.Size(58, 33);
			this.PortBox.TabIndex = 0;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(617, 426);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(536, 425);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// Settings
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(704, 461);
			this.ControlBox = false;
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupProxy);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Settings";
			this.TopMost = true;
			this.groupProxy.ResumeLayout(false);
			this.groupProxy.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupProxy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox IpBox;
		public System.Windows.Forms.TextBox PortBox;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
	}
}