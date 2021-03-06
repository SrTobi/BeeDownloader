﻿// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using BeeDownloader;

namespace MusicBeePlugin
{
	public partial class Plugin
	{
		private MusicBeeApiInterface mApiInterface;
		private PluginInfo about = new PluginInfo();
		private PluginLogic mLogic;

		public PluginInfo Initialise(IntPtr apiInterfacePtr)
		{
			mApiInterface = new MusicBeeApiInterface();
			mApiInterface.Initialise(apiInterfacePtr);
			about.PluginInfoVersion = PluginInfoVersion;
			about.Name = "BeeDownloader";
			about.Description = "Enables you to download audio files from Youtube";
			about.Author = "Tobias Kahlert";
			about.TargetApplication = "";   // current only applies to artwork, lyrics or instant messenger name that appears in the provider drop down selector or target Instant Messenger
			about.Type = PluginType.General;
			about.VersionMajor = 1;  // your plugin version
			about.VersionMinor = 0;
			about.Revision = 1;
			about.MinInterfaceVersion = MinInterfaceVersion;
			about.MinApiRevision = MinApiRevision;
			about.ReceiveNotifications = (ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents);
			about.ConfigurationPanelHeight = 0;   // height in pixels that musicbee should reserve in a panel for config settings. When set, a handle to an empty panel will be passed to the Configure function

			mLogic = new PluginLogic(mApiInterface);

			return about;
		}

		public bool Configure(IntPtr panelHandle)
		{
			mLogic.Configure();
			return true;
		}

		// called by MusicBee when the user clicks Apply or Save in the MusicBee Preferences screen.
		// its up to you to figure out whether anything has changed and needs updating
		public void SaveSettings()
		{
			mLogic.SaveSettings();
		}

		// MusicBee is closing the plugin (plugin is being disabled by user or MusicBee is shutting down)
		public void Close(PluginCloseReason reason)
		{
			mLogic.Close();
		}

		// uninstall this plugin - clean up any persisted files
		public void Uninstall()
		{
		}

		// receive event notifications from MusicBee
		// you need to set about.ReceiveNotificationFlags = PlayerEvents to receive all notifications, and not just the startup event
		public void ReceiveNotification(string sourceFileUrl, NotificationType type)
		{
			// perform some action depending on the notification type
			switch (type)
			{
				case NotificationType.PluginStartup:
					mLogic.Startup();
					break;
			}
		}

		// return an array of lyric or artwork provider names this plugin supports
		// the providers will be iterated through one by one and passed to the RetrieveLyrics/ RetrieveArtwork function in order set by the user in the MusicBee Tags(2) preferences screen until a match is found
		public string[] GetProviders()
		{
			return null;
		}

		// return lyrics for the requested artist/title from the requested provider
		// only required if PluginType = LyricsRetrieval
		// return null if no lyrics are found
		public string RetrieveLyrics(string sourceFileUrl, string artist, string trackTitle, string album, bool synchronisedPreferred, string provider)
		{
			return null;
		}

		// return Base64 string representation of the artwork binary data from the requested provider
		// only required if PluginType = ArtworkRetrieval
		// return null if no artwork is found
		public string RetrieveArtwork(string sourceFileUrl, string albumArtist, string album, string provider)
		{
			//Return Convert.ToBase64String(artworkBinaryData)
			return null;
		}
	}
}