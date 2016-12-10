using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ist303_keeling_j_a7
{
	public partial class frmMain: Form
	{
		string path;

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnBrowse_Click( object sender, EventArgs e )
		{
			FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
			folderBrowser.ShowDialog();
			path = folderBrowser.SelectedPath;
			GetFolders( path );
		}

		void GetFolders( string newPath )
		{
			foreach ( string str in Directory.GetDirectories( newPath ) )
			{
				txtFileList.AppendText( str + "\n" );
				GetFiles( str );
				GetFolders( str );
			}
		}
		void GetFiles( string newPath )
		{
			foreach ( string str in Directory.GetFiles( newPath ) )
			{
				txtFileList.AppendText( str + "\n" );
			}
		}
	}
}
