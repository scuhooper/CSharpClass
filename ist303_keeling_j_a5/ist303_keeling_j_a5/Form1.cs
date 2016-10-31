using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ist303_keeling_j_a5
{
	public partial class frmMain : Form
	{
		HangmanGame game = new HangmanGame();

		public frmMain()
		{
			InitializeComponent();
		}

		private void btnQuit_Click( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void btnSubmitGuess_Click( object sender, EventArgs e )
		{
			if ( mtxtGuess.Text.Length == 0 )
			{
				lblError.Visible = true;
				lblError.Text = "Please enter a letter to guess.";
				return;
			}

			char temp = mtxtGuess.Text.ToUpper()[ 0 ];
			if ( game.lettersGuessed[ temp ] )
			{
				lblError.Visible = true;
				lblError.Text = "The letter " + temp + " has already been guessed.";
			}
			else
			{

				game.SubmitGuess( temp );

				lblError.Visible = false;
				lblHistory.Text = "";
				foreach ( KeyValuePair<char, bool> key in game.lettersGuessed )
				{
					if(key.Value)
						lblHistory.Text += key.Key + " ";
				}
			}
		}

		private void btnPlay_Click( object sender, EventArgs e )
		{
			pnlTitleScreen.Visible = false;
			pnlGame.Visible = true;
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			
		}
	}
}
