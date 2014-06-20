// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using BeeDownloader.Downloader;
using BeeDownloader.Views;
using MusicBeePlugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeeDownloader
{
	class PluginLogic
	{
		private Plugin.MusicBeeApiInterface mApi;
		private DownloaderWindow mWindow;
		private DownloaderTask mTask;
		private PluginSettings mSettings;

		public PluginLogic(Plugin.MusicBeeApiInterface api)
		{
			mApi = api;
		}

		public void Startup()
		{
			LoadSettigns();
			mApi.MB_AddMenuItem("mnuTools/BeeDownloader", "BeeDownloader: Open", OnOpen);
			mTask = new DownloaderTask(mApi, mSettings);
			mWindow = new DownloaderWindow(mTask, mSettings);
		}

		public void Close()
		{
			mWindow.Dispose();
		}

		public void SaveSettings()
		{
			mSettings.Save(mApi.Setting_GetPersistentStoragePath());
		}

		public void LoadSettigns()
		{
			mSettings = PluginSettings.Load(mApi.Setting_GetPersistentStoragePath());
			if(mSettings == null)
			{
				mSettings = new PluginSettings();
				mSettings.Save(mApi.Setting_GetPersistentStoragePath());
			}
		}

		public void Configure()
		{
			SettingsWindow settingsDlg = new SettingsWindow();
			settingsDlg.SetValues(mSettings);

			if(settingsDlg.ShowDialog() == DialogResult.OK)
			{
				settingsDlg.SaveSettings(mSettings);
				SaveSettings();
			}
		}

		private void OnOpen(object sender, EventArgs args)
		{
			mWindow.Show();
		}
	}
}
