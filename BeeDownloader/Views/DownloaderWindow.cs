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

			Exception bwError = null;

			ProgressBox progBox = new ProgressBox();
			progBox.ProgressText = "Search video...";

			BackgroundWorker bw = new BackgroundWorker();
			bw.DoWork += (ev, args) =>
				{
					var videos = DownloadUrlResolver.GetDownloadUrls(link);
					video = videos.Where(info => info.CanExtractAudio)
									.OrderByDescending(info => info.AudioBitrate)
									.FirstOrDefault();
				};
			bw.RunWorkerCompleted += (ev, args) =>
				{
					if (args.Error != null)
					{
						bwError = args.Error;
						progBox.DialogResult = DialogResult.Abort;
					}
					else if(args.Cancelled)
					{
						progBox.DialogResult = DialogResult.Cancel;
					}
					else
					{
						progBox.DialogResult = DialogResult.OK;
					}
				};
			bw.RunWorkerAsync();

			switch(progBox.ShowDialog(this))
			{
				case DialogResult.Cancel:
					return;
				case DialogResult.OK:
					if(video != null)
						break;
					goto case DialogResult.Abort;
				case DialogResult.Abort:
					MessageBox.Show(this, "Failed to get download url!\n" + (bwError != null? bwError.ToString() : "No reason!"), "Error while searching Youtube!");
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
