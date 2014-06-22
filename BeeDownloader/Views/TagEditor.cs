// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BeeDownloader.Views
{
	public partial class TagEditor : Form
	{
		public TagEditor()
		{
			InitializeComponent();
		}

		public string Title { get { return mTitleInput.Text; } }
		public string Artist { get { return mArtistInput.Text; } }

		public void SetFieldsFromTitle(String videoTitle)
		{
			mVideoTitle.Text = videoTitle;
			Regex skipper = new Regex(@"(\|.*)"						// skip |...
										+ @"|(\[[^.]*\])"			// skip [...]
										+ @"|(#[^\s]*)");			// skip #.. ...

			videoTitle = skipper.Replace(videoTitle, "");

			Regex parser = new Regex(@"(?<title>[^-]*)-(?<artist>[^\|\/\;\-\']*).*");

			Match match = parser.Match(videoTitle);

			String title = match.Groups["title"].Value;
			String artist = match.Groups["artist"].Value;

			mTitleInput.Text = title.Trim();
			mArtistInput.Text = artist.Trim();
		}

		private void SwapButton_Click(object sender, EventArgs e)
		{
			var tmp = mTitleInput.Text;
			mTitleInput.Text = mArtistInput.Text;
			mArtistInput.Text = tmp;
		}
	}
}
