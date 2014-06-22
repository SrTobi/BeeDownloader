namespace BeeDownloader.Views
{
	partial class DownloaderWindow
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
			System.Windows.Forms.GroupBox mInputGroup;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.ColumnHeader titleHeader;
			System.Windows.Forms.ColumnHeader artistHeader;
			System.Windows.Forms.ColumnHeader urlHeader;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloaderWindow));
			this.mDownloadButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.mUrlInput = new System.Windows.Forms.TextBox();
			this.mPendingList = new System.Windows.Forms.ListView();
			this.mStopButton = new System.Windows.Forms.Button();
			this.mReportBox = new System.Windows.Forms.TextBox();
			this.mProgress = new System.Windows.Forms.ProgressBar();
			this.mCurrentAction = new System.Windows.Forms.Label();
			mInputGroup = new System.Windows.Forms.GroupBox();
			label1 = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			artistHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			urlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			mInputGroup.SuspendLayout();
			groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mInputGroup
			// 
			mInputGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			mInputGroup.Controls.Add(this.mDownloadButton);
			mInputGroup.Controls.Add(this.label2);
			mInputGroup.Controls.Add(this.mUrlInput);
			mInputGroup.Controls.Add(label1);
			mInputGroup.Location = new System.Drawing.Point(12, 12);
			mInputGroup.Name = "mInputGroup";
			mInputGroup.Size = new System.Drawing.Size(727, 78);
			mInputGroup.TabIndex = 0;
			mInputGroup.TabStop = false;
			mInputGroup.Text = "Input";
			// 
			// mDownloadButton
			// 
			this.mDownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mDownloadButton.Location = new System.Drawing.Point(640, 43);
			this.mDownloadButton.Name = "mDownloadButton";
			this.mDownloadButton.Size = new System.Drawing.Size(81, 23);
			this.mDownloadButton.TabIndex = 1;
			this.mDownloadButton.Text = "Download";
			this.mDownloadButton.UseVisualStyleBackColor = true;
			this.mDownloadButton.Click += new System.EventHandler(this.OnDownloadClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(288, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter a Youtube-URL with the video you want to download.";
			// 
			// mUrlInput
			// 
			this.mUrlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mUrlInput.Location = new System.Drawing.Point(35, 45);
			this.mUrlInput.MaxLength = 4098;
			this.mUrlInput.Name = "mUrlInput";
			this.mUrlInput.Size = new System.Drawing.Size(599, 20);
			this.mUrlInput.TabIndex = 1;
			this.mUrlInput.TextChanged += new System.EventHandler(this.OnLinkInputChanged);
			this.mUrlInput.Enter += new System.EventHandler(this.OnFocus);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 48);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(23, 13);
			label1.TabIndex = 1;
			label1.Text = "Url:";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox1.Controls.Add(this.mPendingList);
			groupBox1.Controls.Add(this.mStopButton);
			groupBox1.Controls.Add(this.mReportBox);
			groupBox1.Controls.Add(this.mProgress);
			groupBox1.Controls.Add(this.mCurrentAction);
			groupBox1.Location = new System.Drawing.Point(12, 106);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(727, 524);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Download";
			// 
			// mPendingList
			// 
			this.mPendingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            titleHeader,
            artistHeader,
            urlHeader});
			this.mPendingList.Location = new System.Drawing.Point(9, 71);
			this.mPendingList.Name = "mPendingList";
			this.mPendingList.Size = new System.Drawing.Size(712, 326);
			this.mPendingList.TabIndex = 4;
			this.mPendingList.UseCompatibleStateImageBehavior = false;
			this.mPendingList.View = System.Windows.Forms.View.Details;
			// 
			// titleHeader
			// 
			titleHeader.Text = "Title";
			titleHeader.Width = 200;
			// 
			// artistHeader
			// 
			artistHeader.Text = "Artist";
			artistHeader.Width = 120;
			// 
			// urlHeader
			// 
			urlHeader.Text = "Video title";
			urlHeader.Width = 380;
			// 
			// mStopButton
			// 
			this.mStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mStopButton.Location = new System.Drawing.Point(665, 42);
			this.mStopButton.Name = "mStopButton";
			this.mStopButton.Size = new System.Drawing.Size(56, 23);
			this.mStopButton.TabIndex = 3;
			this.mStopButton.Text = "Stop";
			this.mStopButton.UseVisualStyleBackColor = true;
			this.mStopButton.Click += new System.EventHandler(this.ToogleDownloading);
			// 
			// mReportBox
			// 
			this.mReportBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mReportBox.Location = new System.Drawing.Point(9, 403);
			this.mReportBox.Multiline = true;
			this.mReportBox.Name = "mReportBox";
			this.mReportBox.ReadOnly = true;
			this.mReportBox.Size = new System.Drawing.Size(712, 115);
			this.mReportBox.TabIndex = 2;
			// 
			// mProgress
			// 
			this.mProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mProgress.Location = new System.Drawing.Point(9, 42);
			this.mProgress.Maximum = 10000;
			this.mProgress.Name = "mProgress";
			this.mProgress.Size = new System.Drawing.Size(650, 23);
			this.mProgress.TabIndex = 1;
			// 
			// mCurrentAction
			// 
			this.mCurrentAction.AutoSize = true;
			this.mCurrentAction.Location = new System.Drawing.Point(6, 22);
			this.mCurrentAction.Name = "mCurrentAction";
			this.mCurrentAction.Size = new System.Drawing.Size(80, 13);
			this.mCurrentAction.TabIndex = 0;
			this.mCurrentAction.Text = "Nothing to do...";
			// 
			// DownloaderWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 642);
			this.Controls.Add(groupBox1);
			this.Controls.Add(mInputGroup);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DownloaderWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BeeDownloader";
			this.Activated += new System.EventHandler(this.OnFocus);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
			mInputGroup.ResumeLayout(false);
			mInputGroup.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button mDownloadButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox mUrlInput;
		private System.Windows.Forms.ProgressBar mProgress;
		private System.Windows.Forms.Label mCurrentAction;
		private System.Windows.Forms.TextBox mReportBox;
		private System.Windows.Forms.ListView mPendingList;
		private System.Windows.Forms.Button mStopButton;

	}
}