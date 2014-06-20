// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoutubeExtractor;

namespace BeeDownloader.Downloader
{
	public class DownloadVideo
	{
		public readonly string Title;
		public readonly string Artist;
		public readonly VideoInfo Info;

		public DownloadVideo(string title, string artist, VideoInfo info)
		{
			Title = title;
			Artist = artist;
			Info = info;
		}

		public string OriginalTitle { get { return Info.Title; } }
	}
}
