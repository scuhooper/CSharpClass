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
		string path;	// hold file path returned from file dialog box

		public frmMain()
		{
			InitializeComponent();
		}

		private async void btnBrowse_Click( object sender, EventArgs e )
		{
			// open a folder browser
			FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
			folderBrowser.ShowDialog();

			if ( folderBrowser.SelectedPath == string.Empty )	// check if user backed out of folderbrowser without making a selection - will break if removed
				return;

			path = folderBrowser.SelectedPath;	// get the chosen path
			await Task.Run( () => GetFolders( path, chkSubdirectories.CheckState ) );	// get the folders and files from the path - runs asynchronously
		}

		/// <summary>
		/// Add list of folders inside a given directory to text box. Will also add files listed inside directory. Can search subdirectories.
		/// </summary>
		/// <param name="newPath">File path for directory to search</param>
		/// <param name="check">The status of the include subdirectory checkbox at time of search</param>
		void GetFolders( string newPath, CheckState check )
		{
			GetFiles( newPath );	// prints list of files in directory to textbox
			foreach ( string str in Directory.GetDirectories( newPath ) )	// cycle through list of folders
			{
				txtFileList.AppendText( str + "\n" );	// add folder to text box
				if ( check == CheckState.Checked )   // only run if getting subdirectories
					// try block to see if exception for WindowsIO is thrown
					try
					{
						GetFolders( str, check );	// get folders/files in subdirectory
					}
					catch
					{
						continue;	// if we catch an error, just go to next loop iteration
					}
			}
		}

		/// <summary>
		/// Add list of files inside a given directory to the rich text box
		/// </summary>
		/// <param name="newPath">The file path for directory to search</param>
		void GetFiles( string newPath )
		{
			foreach ( string str in Directory.GetFiles( newPath ) )
			{
				txtFileList.AppendText( str + "\n" );	// add file names to text box
			}
		}

		private void btnQuit_Click( object sender, EventArgs e )
		{
			Application.Exit();	// just leave
		}
	}
}
