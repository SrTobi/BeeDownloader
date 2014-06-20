namespace BeeDownloader.Views
{
	partial class TagEditor
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
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Button button1;
			System.Windows.Forms.Button button2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagEditor));
			this.mVideoTitle = new System.Windows.Forms.Label();
			this.SwapButton = new System.Windows.Forms.Button();
			this.mArtistInput = new System.Windows.Forms.TextBox();
			this.mTitleInput = new System.Windows.Forms.TextBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label2 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			groupBox1.Controls.Add(this.mVideoTitle);
			groupBox1.Controls.Add(this.SwapButton);
			groupBox1.Controls.Add(this.mArtistInput);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(this.mTitleInput);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(431, 156);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Tags";
			// 
			// mVideoTitle
			// 
			this.mVideoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mVideoTitle.Location = new System.Drawing.Point(18, 106);
			this.mVideoTitle.Name = "mVideoTitle";
			this.mVideoTitle.Size = new System.Drawing.Size(403, 35);
			this.mVideoTitle.TabIndex = 5;
			this.mVideoTitle.Text = "hallo";
			// 
			// SwapButton
			// 
			this.SwapButton.BackgroundImage = global::BeeDownloader.Properties.Resources.swap;
			this.SwapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.SwapButton.Location = new System.Drawing.Point(15, 45);
			this.SwapButton.Name = "SwapButton";
			this.SwapButton.Size = new System.Drawing.Size(33, 26);
			this.SwapButton.TabIndex = 4;
			this.SwapButton.UseVisualStyleBackColor = true;
			this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
			// 
			// mArtistInput
			// 
			this.mArtistInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mArtistInput.Location = new System.Drawing.Point(51, 74);
			this.mArtistInput.Name = "mArtistInput";
			this.mArtistInput.Size = new System.Drawing.Size(374, 20);
			this.mArtistInput.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(18, 77);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(33, 13);
			label2.TabIndex = 2;
			label2.Text = "Artist:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(18, 28);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(30, 13);
			label1.TabIndex = 1;
			label1.Text = "Title:";
			// 
			// mTitleInput
			// 
			this.mTitleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mTitleInput.Location = new System.Drawing.Point(51, 25);
			this.mTitleInput.Name = "mTitleInput";
			this.mTitleInput.Size = new System.Drawing.Size(374, 20);
			this.mTitleInput.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			button1.Location = new System.Drawing.Point(368, 181);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "Download";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			button2.Location = new System.Drawing.Point(287, 181);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			// 
			// TagEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 216);
			this.Controls.Add(button2);
			this.Controls.Add(button1);
			this.Controls.Add(groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TagEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BeeDownloader - Tag Editor";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox mTitleInput;
		private System.Windows.Forms.Label mVideoTitle;
		private System.Windows.Forms.Button SwapButton;
		private System.Windows.Forms.TextBox mArtistInput;
	}
}