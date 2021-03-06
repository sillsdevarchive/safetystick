namespace SafetyStick
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Paratext",
            "Will be backed up"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("AdaptIt");
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "WeSay (Not found)"}, -1, System.Drawing.SystemColors.GrayText, System.Drawing.Color.Empty, null);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Other Documents");
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Music (Not Enough Space)"}, -1, System.Drawing.SystemColors.GrayText, System.Drawing.Color.Empty, null);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Video (Not Enough Space)"}, -1, System.Drawing.SystemColors.GrayText, System.Drawing.SystemColors.Window, null);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.backupNowButton = new System.Windows.Forms.Button();
			this.syncProgressBar = new System.Windows.Forms.ProgressBar();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.closeButton = new System.Windows.Forms.Button();
			this._upperStatusLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this._mediaStatusIndicator = new SafetyStick.MediaStatus();
			this._safeToRemoveLabel = new System.Windows.Forms.Label();
			this._lowerStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// backupNowButton
			// 
			this.backupNowButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.backupNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backupNowButton.Location = new System.Drawing.Point(129, 251);
			this.backupNowButton.Name = "backupNowButton";
			this.backupNowButton.Size = new System.Drawing.Size(340, 89);
			this.backupNowButton.TabIndex = 0;
			this.backupNowButton.Text = "Backup Now\r\n(Press Enter)";
			this.backupNowButton.UseVisualStyleBackColor = true;
			this.backupNowButton.Click += new System.EventHandler(this.backupNowButton_Click);
			// 
			// syncProgressBar
			// 
			this.syncProgressBar.Location = new System.Drawing.Point(129, 251);
			this.syncProgressBar.Name = "syncProgressBar";
			this.syncProgressBar.Size = new System.Drawing.Size(340, 31);
			this.syncProgressBar.TabIndex = 2;
			this.syncProgressBar.Visible = false;
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
			this.listView1.Location = new System.Drawing.Point(129, 45);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(340, 152);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Size";
			this.columnHeader2.Width = 189;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "");
			this.imageList1.Images.SetKeyName(1, "DeleteMessageBoxImage.png");
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.Location = new System.Drawing.Point(335, 284);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(134, 56);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "&Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// statusLabel
			// 
			this._upperStatusLabel.AutoSize = true;
			this._upperStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._upperStatusLabel.Location = new System.Drawing.Point(129, 22);
			this._upperStatusLabel.Name = "_upperStatusLabel";
			this._upperStatusLabel.Size = new System.Drawing.Size(171, 17);
			this._upperStatusLabel.TabIndex = 6;
			this._upperStatusLabel.Text = "{0} files will be backed up:";
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(394, 317);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.OnCancelClick);
			// 
			// mediaStatus1
			// 
			this._mediaStatusIndicator.BackColor = System.Drawing.Color.Transparent;
			this._mediaStatusIndicator.DeviceSizeInKiloBytes = ((long)(131072));
			this._mediaStatusIndicator.ExistingFillPercentage = 50;
			this._mediaStatusIndicator.Location = new System.Drawing.Point(10, 17);
			this._mediaStatusIndicator.Name = "_mediaStatusIndicator";
			this._mediaStatusIndicator.PendingFillPercentage = 25;
			this._mediaStatusIndicator.Size = new System.Drawing.Size(100, 323);
			this._mediaStatusIndicator.TabIndex = 3;
			// 
			// _safeToRemoveLabel
			// 
			this._safeToRemoveLabel.AutoSize = true;
			this._safeToRemoveLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._safeToRemoveLabel.ForeColor = System.Drawing.Color.Teal;
			this._safeToRemoveLabel.Location = new System.Drawing.Point(129, 200);
			this._safeToRemoveLabel.Name = "_safeToRemoveLabel";
			this._safeToRemoveLabel.Size = new System.Drawing.Size(356, 21);
			this._safeToRemoveLabel.TabIndex = 8;
			this._safeToRemoveLabel.Text = "It is now safe to remove the USB Memory Stick.";
			this._safeToRemoveLabel.Visible = false;
			// 
			// _lowerStatus
			// 
			this._lowerStatus.AutoSize = true;
			this._lowerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lowerStatus.Location = new System.Drawing.Point(130, 231);
			this._lowerStatus.Name = "_lowerStatus";
			this._lowerStatus.Size = new System.Drawing.Size(114, 17);
			this._lowerStatus.TabIndex = 6;
			this._lowerStatus.Text = "this will be status";
			// 
			// MainWindow
			// 
			this.AcceptButton = this.backupNowButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(492, 354);
			this.Controls.Add(this._safeToRemoveLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this._lowerStatus);
			this.Controls.Add(this._upperStatusLabel);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this._mediaStatusIndicator);
			this.Controls.Add(this.syncProgressBar);
			this.Controls.Add(this.backupNowButton);
			this.Controls.Add(this.closeButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.Text = "SafetyStick";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backupNowButton;
		private System.Windows.Forms.ProgressBar syncProgressBar;
		private MediaStatus _mediaStatusIndicator;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label _upperStatusLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label _safeToRemoveLabel;
		private System.Windows.Forms.Label _lowerStatus;
	}
}

