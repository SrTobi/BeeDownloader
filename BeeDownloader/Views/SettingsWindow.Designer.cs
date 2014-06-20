namespace BeeDownloader.Views
{
	partial class SettingsWindow
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
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.Button button1;
			System.Windows.Forms.Button button2;
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.Button button3;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
			this.mDownloadFolderInput = new System.Windows.Forms.TextBox();
			this.mAutoURLClipboardCopyInput = new System.Windows.Forms.CheckBox();
			this.mMoveDownloadedFilesToInboxInput = new System.Windows.Forms.CheckBox();
			this.mSetMediaTagsInput = new System.Windows.Forms.CheckBox();
			this.mUseTagEditorInput = new System.Windows.Forms.CheckBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			groupBox2 = new System.Windows.Forms.GroupBox();
			button3 = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(this.mDownloadFolderInput);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(376, 51);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Download Folder";
			// 
			// button1
			// 
			button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			button1.Location = new System.Drawing.Point(313, 197);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			button2.Location = new System.Drawing.Point(232, 197);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			// 
			// mDownloadFolderInput
			// 
			this.mDownloadFolderInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mDownloadFolderInput.Location = new System.Drawing.Point(6, 19);
			this.mDownloadFolderInput.Name = "mDownloadFolderInput";
			this.mDownloadFolderInput.Size = new System.Drawing.Size(332, 20);
			this.mDownloadFolderInput.TabIndex = 3;
			// 
			// mAutoURLClipboardCopyInput
			// 
			this.mAutoURLClipboardCopyInput.AutoSize = true;
			this.mAutoURLClipboardCopyInput.Location = new System.Drawing.Point(16, 19);
			this.mAutoURLClipboardCopyInput.Name = "mAutoURLClipboardCopyInput";
			this.mAutoURLClipboardCopyInput.Size = new System.Drawing.Size(262, 17);
			this.mAutoURLClipboardCopyInput.TabIndex = 3;
			this.mAutoURLClipboardCopyInput.Text = "Copy URLs from clipboard, when window is active";
			this.mAutoURLClipboardCopyInput.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox2.Controls.Add(this.mUseTagEditorInput);
			groupBox2.Controls.Add(this.mSetMediaTagsInput);
			groupBox2.Controls.Add(this.mMoveDownloadedFilesToInboxInput);
			groupBox2.Controls.Add(this.mAutoURLClipboardCopyInput);
			groupBox2.Location = new System.Drawing.Point(12, 69);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(376, 122);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Options";
			// 
			// mMoveDownloadedFilesToInboxInput
			// 
			this.mMoveDownloadedFilesToInboxInput.AutoSize = true;
			this.mMoveDownloadedFilesToInboxInput.Location = new System.Drawing.Point(16, 42);
			this.mMoveDownloadedFilesToInboxInput.Name = "mMoveDownloadedFilesToInboxInput";
			this.mMoveDownloadedFilesToInboxInput.Size = new System.Drawing.Size(179, 17);
			this.mMoveDownloadedFilesToInboxInput.TabIndex = 4;
			this.mMoveDownloadedFilesToInboxInput.Text = "Move downloaded Files to Inbox";
			this.mMoveDownloadedFilesToInboxInput.UseVisualStyleBackColor = true;
			// 
			// mSetMediaTagsInput
			// 
			this.mSetMediaTagsInput.AutoSize = true;
			this.mSetMediaTagsInput.Location = new System.Drawing.Point(16, 65);
			this.mSetMediaTagsInput.Name = "mSetMediaTagsInput";
			this.mSetMediaTagsInput.Size = new System.Drawing.Size(178, 17);
			this.mSetMediaTagsInput.TabIndex = 5;
			this.mSetMediaTagsInput.Text = "Set media tag after downloading";
			this.mSetMediaTagsInput.UseVisualStyleBackColor = true;
			// 
			// mUseTagEditorInput
			// 
			this.mUseTagEditorInput.AutoSize = true;
			this.mUseTagEditorInput.Location = new System.Drawing.Point(16, 88);
			this.mUseTagEditorInput.Name = "mUseTagEditorInput";
			this.mUseTagEditorInput.Size = new System.Drawing.Size(196, 17);
			this.mUseTagEditorInput.TabIndex = 6;
			this.mUseTagEditorInput.Text = "Open tag editor to edit title and artist";
			this.mUseTagEditorInput.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			button3.Location = new System.Drawing.Point(344, 17);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(26, 23);
			button3.TabIndex = 7;
			button3.Text = "...";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(this.OnChooseDownloadFolder);
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 232);
			this.Controls.Add(groupBox2);
			this.Controls.Add(button2);
			this.Controls.Add(button1);
			this.Controls.Add(groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingsWindow";
			this.Text = "BeeDownloader - Settings";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox mDownloadFolderInput;
		private System.Windows.Forms.CheckBox mAutoURLClipboardCopyInput;
		private System.Windows.Forms.CheckBox mMoveDownloadedFilesToInboxInput;
		private System.Windows.Forms.CheckBox mSetMediaTagsInput;
		private System.Windows.Forms.CheckBox mUseTagEditorInput;
	}
}