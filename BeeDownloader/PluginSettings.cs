// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeeDownloader
{
	public class PluginSettings
	{
		public static readonly string SETTINGS_FILE = "BeeDownloader_Settings.xml";

		public bool UseTagEditor { get; set; }
		public bool SetMediaTags { get; set; }
		public bool MoveDownloadedFilesToInbox { get; set; }
		public bool AutoURLClipboardCopy { get; set; }
		public string DownloadFolder { get; set; }

		public PluginSettings()
		{
			UseTagEditor = true;
			SetMediaTags = true;
			MoveDownloadedFilesToInbox = true;
			AutoURLClipboardCopy = true;
			DownloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}


		public void Save(string path)
		{
			try {
				using (var file = new StreamWriter(Path.Combine(path, SETTINGS_FILE)))
				{
					System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(GetType());
					x.Serialize(file, this);
				}
			}catch(IOException ex)
			{
				MessageBox.Show("Failed to save settings: " + ex.Message);
			}

		}

		public static PluginSettings Load(string path)
		{
			try
			{
				using (var file = new FileStream(Path.Combine(path, SETTINGS_FILE), FileMode.Open))
				{
					System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(PluginSettings));
					return x.Deserialize(file) as PluginSettings;
				}
			}catch(IOException)
			{

			}
			return null;
		}
	}
}
