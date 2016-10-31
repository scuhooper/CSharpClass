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
		Label[] hangman = new Label[ 6 ];
		int nextBodyPart = 0;

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
			if ( game.lettersGuessed.ContainsKey(temp) )
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
				lblSecretWord.Text = game.PrintDisplayedWord();
				mtxtGuess.Text = "";

				if ( !game.IsLetterInWord() )
				{
					hangman[ nextBodyPart ].Visible = true;
					nextBodyPart++;
					if ( nextBodyPart >= hangman.Length )
					{
						lblError.Text = "You have run out of guesses!";
						lblError.Visible = true;
						mtxtGuess.Enabled = false;
						btnSubmitGuess.Enabled = false;
						btnReset.Visible = true;
					}	
				}
			}
		}

		private void btnPlay_Click( object sender, EventArgs e )
		{
			ResetForm();

			ResetGame();
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			lblSecretWord.Text = game.PrintDisplayedWord();
			hangman[ 0 ] = lblHead;
			hangman[ 1 ] = lblBody;
			hangman[ 2 ] = lblRightArm;
			hangman[ 3 ] = lblLeftArm;
			hangman[ 4 ] = lblRightLeg;
			hangman[ 5 ] = lblLeftLeg;
		}

		void ResetForm()
		{
			pnlTitleScreen.Visible = false;
			pnlGame.Visible = true;
			btnReset.Visible = false;
			lblError.Visible = false;
			btnSubmitGuess.Enabled = true;
			mtxtGuess.Enabled = true;
		}
		void ResetGame()
		{
			game.Reset();
			lblSecretWord.Text = game.PrintDisplayedWord();
			lblHistory.Text = "";

			foreach ( Label l in hangman )
				l.Visible = false;
		}
	}
}
