// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Collections.Generic;
using YoutubeExtractor;
using System.IO;
using MusicBeePlugin;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BeeDownloader.Downloader
{
	public class DownloaderTask
	{
		public delegate void StateChangeEvent(String status, double progress);
		public event StateChangeEvent ProgressEvent;

		private bool mRunning = true;
		private PluginSettings mSettings;
		private BackgroundWorker mWorker;
		private ConcurrentQueue<DownloadVideo> mPendingVideos;
		private DownloadVideo mCurrentVideoDownload;
		private Plugin.MusicBeeApiInterface mApi;

		public bool Running
		{
			get { return mRunning; }
			set
			{
				if(mRunning = value)
				{
					if (!mPendingVideos.IsEmpty && !mWorker.IsBusy)
						mWorker.RunWorkerAsync();
				}else
				{
					if(mWorker.IsBusy)
						mWorker.CancelAsync();
				}
			}
		}

		public DownloaderTask(Plugin.MusicBeeApiInterface api, PluginSettings settings)
		{
			mApi = api;
			mSettings = settings;
			mPendingVideos = new ConcurrentQueue<DownloadVideo>();
			mWorker = new BackgroundWorker();
			mWorker.DoWork += Run;
			mWorker.RunWorkerCompleted += Completed;
			mWorker.WorkerSupportsCancellation = true;
		}

		public DownloadVideo CurrentVideo
		{
			get { return mCurrentVideoDownload; }
		}

		public IEnumerable<DownloadVideo> PendingVideos
		{
			get { return mPendingVideos.AsEnumerable(); }
		}

		public void AddVideo(DownloadVideo video)
		{
			mPendingVideos.Enqueue(video);
			Running = true;
		}


		private void Run(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;

			while(!mWorker.CancellationPending && mPendingVideos.TryDequeue(out mCurrentVideoDownload))
			{
				var video = mCurrentVideoDownload.Info;
				var target = Path.Combine(mSettings.DownloadFolder, FixFilePath(video.Title + video.AudioExtension));
				var audioDownloader = new AudioDownloader(video, target);

				ProgressEvent("Start downloading...", 0.0);
				ProgressEvent("Target file: " + target, 0.0);

				// set events
				const double downloadPart = 0.95;

				audioDownloader.DownloadProgressChanged +=
					(s, args) =>
					{
						if(worker.CancellationPending)
							args.Cancel = true;
						ProgressEvent(null, args.ProgressPercentage / 100.0 * downloadPart);
					};

				audioDownloader.AudioExtractionProgressChanged +=
					(s, args) =>
					{
						if (worker.CancellationPending)
							args.Cancel = true;
						ProgressEvent(null, downloadPart + args.ProgressPercentage / 100.0 * (1 - downloadPart));
					};

				audioDownloader.DownloadFinished +=
					(s, args) => 
					{
						ProgressEvent("File downloaded!", downloadPart);
						ProgressEvent("Start extracting...", downloadPart);
					};

				// Download and extract...
				try
				{
					audioDownloader.Execute();
				}catch(Exception ex)
				{
					ProgressEvent("Error: " + ex.Message, 1.0);
					continue;
				}

				if(worker.CancellationPending)
				{
					mPendingVideos.Enqueue(mCurrentVideoDownload);
				}
				else
				{
					// Done
					ProgressEvent("Audio track extracted!", 1.0);

					if (mSettings.SetMediaTags)
					{
						var tags = TagLib.File.Create(target);
						tags.Tag.Title = mCurrentVideoDownload.Title;
						tags.Tag.Performers = new string[] { mCurrentVideoDownload.Artist };
						tags.Save();
					}

					if (mSettings.MoveDownloadedFilesToInbox)
					{
						ProgressEvent("Move audio file to inbox...", 1.0);
						mApi.Library_AddFileToLibrary(target, Plugin.LibraryCategory.Inbox);
					}

					ProgressEvent("Done.", 1.0);
				}


				mCurrentVideoDownload = null;
			}

			e.Cancel = worker.CancellationPending;
		}



		private void Completed(object sender, RunWorkerCompletedEventArgs e)
		{
			if(e.Error != null)
			{
				MessageBox.Show("Error in background worker: " + e.Error.Message);
			}else if(e.Cancelled)
			{
				ProgressEvent("Downloading canceled!", 0.0);
			}
			else
			{
				ProgressEvent("All videos downloaded! No pending videos left!", 0.0f);
			}
		}


		private string FixFilePath(string input)
		{
			string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
			Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
			return r.Replace(input, "");
		}
	}
}
