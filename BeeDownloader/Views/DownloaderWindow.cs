// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using BeeDownloader.Downloader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YoutubeExtractor;

namespace BeeDownloader.Views
{
	public partial class DownloaderWindow : Form
	{
		private DownloaderTask mTask;
		private PluginSettings mSettings;

		public DownloaderWindow(DownloaderTask task, PluginSettings settings)
		{
			mSettings = settings;
			mTask = task;
			mTask.ProgressEvent += OnProgress;
			InitializeComponent();
		}

		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}


		private void OnDownloadClicked(object sender, EventArgs e)
		{
			string link = mUrlInput.Text;
			VideoInfo video = null;
			
			try
			{
				var videos = DownloadUrlResolver.GetDownloadUrls(link);
				video = videos.Where(info => info.CanExtractAudio)
								.OrderByDescending(info => info.AudioBitrate)
								.FirstOrDefault();

			}catch(ArgumentException ex)
			{
				MessageBox.Show(ex.Message);
				return;

			}catch(YoutubeParseException)
			{
				MessageBox.Show("Failed to parse the Youtube page!");
				return;

			}catch(VideoNotAvailableException)
			{
				MessageBox.Show("Video is not accessible!");
				return;
			}


			if(video == null)
			{
				MessageBox.Show("No video found!");
				return;
			}

			DownloadVideo dvideo = null;
			if(mSettings.UseTagEditor)
			{
				TagEditor tagEditor = new TagEditor();
				tagEditor.SetFieldsFromTitle(video.Title);
				tagEditor.StartPosition = FormStartPosition.CenterParent;
				if(tagEditor.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
				{
					dvideo = new DownloadVideo(tagEditor.Title, tagEditor.Artist, video);
				}
				else
				{
					return;
				}
			}
			else
			{
				dvideo = new DownloadVideo(video.Title, "", video);
			}


			mUrlInput.Text = "";
			mReportBox.AppendText("Add video to pending: " + video.Title + "\n");
			mTask.AddVideo(dvideo);
			mStopButton.Text = "Stop";
			fillListView();
		}

		private void OnProgress(string status, double progress)
		{
			this.Invoke((MethodInvoker)delegate {

				if(status != null)
				{
					mReportBox.AppendText(status + "\n");
					var current = mTask.CurrentVideo;
					fillListView();

					if(current != null)
					{
						mCurrentAction.Text = "Downloading " + current.OriginalTitle;
					}
					else
					{
						mCurrentAction.Text = "Nothing to do!";
					}
				}
				mProgress.Value = (int)(progress * 10000.0);
			
			});
		}

		private void OnFocus(object sender, EventArgs e)
		{
			if (mSettings.AutoURLClipboardCopy && string.IsNullOrEmpty(mUrlInput.Text))
			{
				string text = Clipboard.GetText();

				string downloadUrl = (mTask.CurrentVideo != null ? mTask.CurrentVideo.Info.DownloadUrl : null);
				
				string normalized;
				if (DownloadUrlResolver.TryNormalizeYoutubeUrl(text, out normalized)
					&& !string.Equals(normalized, downloadUrl))
				{
					foreach(var track in mTask.PendingVideos)
					{
						if(string.Equals(track.Info.DownloadUrl, normalized))
						{
							return;
						}
					}

					mUrlInput.Text = text;
				}
			}
		}

		private void ToogleDownloading(object sender, EventArgs e)
		{
			if(mTask.Running = !mTask.Running)
			{
				mStopButton.Text = "Stop";
			}
			else
			{
				mStopButton.Text = "Resume";
			}
		}

		private void fillListView()
		{
			mPendingList.BeginUpdate();
			mPendingList.Items.Clear();
			foreach(var track in mTask.PendingVideos)
			{
				mPendingList.Items.Add(new ListViewItem(new string[] { track.Title, track.Artist, track.OriginalTitle }));
			}
			mPendingList.EndUpdate();
		}
	}
}
