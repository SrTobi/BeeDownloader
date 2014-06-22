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
	public partial class ProgressBox : Form
	{
		public ProgressBox()
		{
			InitializeComponent();
		}

		public string ProgressText
		{
			get { return mText.Text; }
			set { mText.Text = value; }
		}
	}
}
