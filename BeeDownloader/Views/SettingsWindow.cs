// (c) 2014 Kahlert
// This code is licensed under MIT license (see LICENSE.md for details)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeeDownloader.Views
{
	public partial class SettingsWindow : Form
	{
		public SettingsWindow()
		{
			InitializeComponent();
		}

		public void SetValues(PluginSettings settings)
		{
			mDownloadFolderInput.Text = settings.DownloadFolder;
			mAutoURLClipboardCopyInput.Checked = settings.AutoURLClipboardCopy;
			mSetMediaTagsInput.Checked = settings.SetMediaTags;
			mMoveDownloadedFilesToInboxInput.Checked = settings.MoveDownloadedFilesToInbox;
			mUseTagEditorInput.Checked = settings.UseTagEditor;
		}

		public void SaveSettings(PluginSettings settings)
		{
			settings.DownloadFolder = mDownloadFolderInput.Text;
			settings.AutoURLClipboardCopy = mAutoURLClipboardCopyInput.Checked;
			settings.SetMediaTags = mSetMediaTagsInput.Checked;
			settings.MoveDownloadedFilesToInbox = mMoveDownloadedFilesToInboxInput.Checked;
			settings.UseTagEditor = mUseTagEditorInput.Checked;
		}

		private void OnChooseDownloadFolder(object sender, EventArgs e)
		{
			FolderBrowserDialog folderDlg = new FolderBrowserDialog();
			folderDlg.SelectedPath = mDownloadFolderInput.Text;

			if(folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				mDownloadFolderInput.Text = folderDlg.SelectedPath;
			}
		}
	}
}
