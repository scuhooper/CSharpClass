using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ist303_keeling_j_a6
{
	public partial class frmMain: Form
	{
		List<Activity> activityList = new List<Activity>();	// list of activities for todo list

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			// read from a file if one exists already
			if ( File.Exists( "todolist.txt" ) )
			{
				byte[] buffer = File.ReadAllBytes( "todolist.txt" );	// get file contents as bytes

				if ( buffer.Length == 0 )	// check if file was empty, will get bounds errors without this checking
					return;

				string temp = Encoding.ASCII.GetString( buffer );	// convert bytes to string
				temp = temp.Remove( temp.Length - 1, 1 );	// remove the trailing commma delimiter to avoid bounds errors
				string[] splitStrings = temp.Split( ',' );	// split string using comma delimiters

				// if we have an odd number of strings after the split, we have an error with the file
				if ( splitStrings.Length % 2 == 0 )
				{
					int index = 0;	// start index for splitStrings at 0

					// add activities to list until we reach the end of splitStrings
					while ( index < splitStrings.Length )
					{
						activityList.Add( new Activity( DateTime.Parse( splitStrings[ index ] ), splitStrings[ index + 1 ] ) );	// DateTime Parse allows a string formatted date to be transformed back into datetime object
						index += 2;	// update index
					}

					// copy activity list to list box
					foreach ( Activity a in activityList )
						lstToDoList.Items.Add( a );
				}
				else
				{	
					// file has corrupt data. this alerts user and deletes the file
					MessageBox.Show( "The file has been altered. Starting with a blank ToDo list." );
					File.Delete( "todolist.txt" );
				}
			}
		}

		private void btnQuit_Click( object sender, EventArgs e )
		{
			if ( activityList.Count == 0 )	// if list is empty, don't make empty file
				Application.Exit();

			File.WriteAllText( "todolist.txt", string.Empty );	// overwrite files contents
			FileStream listFile = File.OpenWrite( "todolist.txt" ); // open file for writing
			string stringFromList = string.Empty;	// set string to empty

			// add each activity as a string to stringFromList
			foreach ( Activity a in activityList )
			{
				stringFromList += a.date.ToString() + "," + a.name + ",";				
			}

			byte[] buffer = Encoding.ASCII.GetBytes( stringFromList );	// convert string to byte array
			listFile.Write( buffer, 0, buffer.Length );	// write byte array to disk
			listFile.Close();	// clost file
			Application.Exit();	// exit app
		}

		private void btnAddActivity_Click( object sender, EventArgs e )
		{
			// ensure activity has a name before adding it to list
			if ( txtActivityName.Text.Length == 0 )
				MessageBox.Show( "Please enter a name for the activity" );
			else
			{
				// get a better time and date. utilizes two DateTimePickers to allow user to set time and date separately
				DateTime tempDay = new DateTime( dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second );

				// add the activity to our lists
				activityList.Add( new Activity( tempDay, txtActivityName.Text ) );	
				lstToDoList.Items.Add( activityList[ activityList.Count - 1 ] );

				// reset form
				txtActivityName.Clear();
				dtpDate.ResetText();
				dtpTime.ResetText();
			}
		}

		private void btnRemoveActivity_Click( object sender, EventArgs e )
		{
			lstToDoList.Items.Remove( lstToDoList.Items[ lstToDoList.SelectedIndex ] );	// remove item from listbox
			UpdateActivityList();	// copy list box list to activity list
		}

		private void btnDateSort_Click( object sender, EventArgs e )
		{
			var dateSortedList = from act in activityList orderby act.date ascending select act;	// sort list by date ascending
			lstToDoList.Items.Clear();	// clear the list box

			// add new sorted list into list box
			foreach ( Activity act in dateSortedList )
				lstToDoList.Items.Add( act );

			UpdateActivityList();	// copy list box list to activty list
		}

		private void btnNameSort_Click( object sender, EventArgs e )
		{
			var nameSortedList = from act in activityList orderby act.name ascending select act;	// sort list by name in alphabetical order
			lstToDoList.Items.Clear();  // clear the list box

			// add new sorted list into list box
			foreach ( Activity act in nameSortedList )
				lstToDoList.Items.Add( act );

			UpdateActivityList();   // copy list box list to activty list
		}

		void UpdateActivityList()
		{
			activityList.Clear();	// empty activity list

			// copy list box list into activity list
			foreach ( Activity act in lstToDoList.Items )
				activityList.Add( act );
		}
	}
}
