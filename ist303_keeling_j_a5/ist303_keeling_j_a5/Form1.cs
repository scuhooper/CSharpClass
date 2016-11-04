using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ist303_keeling_j_a5
{
	public partial class frmMain : Form
	{
		HangmanGame game = new HangmanGame();	// create variable of game object for form
		Label[] hangman = new Label[ 6 ];	// create an array of the 6 hangman labels for incorrect guesses
		int nextBodyPart = 0;	// keep track of which body part should be displayed next

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
			if ( mtxtGuess.Text.Length == 0 )	// check if there is no input in the text box
			{
				// print error message letting user know they need to enter a guess
				lblError.Visible = true;
				lblError.Text = "Please enter a letter to guess.";
				return;
			}

			char temp = mtxtGuess.Text.ToUpper()[ 0 ];	// get the letter from the Guess text box and make it uppercase
			bool bOut;	// just for the out param in TryGetValue
			if ( game.lettersGuessed.TryGetValue(temp, out bOut)) //game.lettersGuessed.ContainsKey(temp) )	// check if hashtable has a key listed for the character guessed
			{
				// print error letting user know the letter has already been guessed
				lblError.Visible = true;
				lblError.Text = "The letter " + temp + " has already been guessed.";
				mtxtGuess.Text = "";
			}
			else
			{
				game.SubmitGuess( temp );	// submit letter guessed to game logic

				lblError.Visible = false;   // hide the error label as it no longer applies
				lblHistory.Text = "";	// make the history of guessed letters empty

				foreach ( KeyValuePair<char, bool> key in game.lettersGuessed )
				{
					if(key.Value)
						lblHistory.Text += key.Key + " ";	// add all the keys (chars) that have been guessed to the history of guessed letters printed on screen
				}

				lblSecretWord.Text = game.GetDisplayedWord();	// set the text for the secret word on the screen to be the updated displayed word
				mtxtGuess.Text = "";	// clear the contents of the guess text box

				if ( !game.IsLetterInWord() )	// if the guess was incorrect
				{
					DrawHangman();	// draw next piece of the hangman
				}
				else if ( game.CheckForWinner() )	// if the guess was correct, check if the game has been won
				{
					VictoryScreen();	// display the victory screen
				}

			}
		}

		private void btnPlay_Click( object sender, EventArgs e )
		{
			// when play or play again is clicked, reset the game and form
			ResetForm();
			ResetGame();
		}

		private void frmMain_Load( object sender, EventArgs e )
		{
			lblSecretWord.Text = game.GetDisplayedWord();	// make the secret word on the form resemble that of the displayed word from hangman

			// instantiate the array of hangman body parts to be displayed
			hangman[ 0 ] = lblHead;
			hangman[ 1 ] = lblBody;
			hangman[ 2 ] = lblRightArm;
			hangman[ 3 ] = lblLeftArm;
			hangman[ 4 ] = lblRightLeg;
			hangman[ 5 ] = lblLeftLeg;
		}

		/// <summary>
		/// Resets the Windows form to show a new game of hangman
		/// </summary>
		void ResetForm()
		{
			pnlTitleScreen.Visible = false;	// hide the menu panel
			pnlGame.Visible = true;	// show the game panel
			btnReset.Visible = false;   // hide the play again button
			lblError.Visible = false;	// hide the error label

			// enable the player to be able to make guesses
			btnSubmitGuess.Enabled = true;
			mtxtGuess.Enabled = true;
		}

		/// <summary>
		/// Reset the hangman game variable
		/// </summary>
		void ResetGame()
		{
			game.Reset();	// calls the reset function of the actual hangman game object
			lblSecretWord.Text = game.GetDisplayedWord();	// sets the secret word on the form to be that of the displayed word for hangman
			lblHistory.Text = "";   // clears the letters guessed history

			// hide all the hangman body parts for incorrect guesses
			foreach ( Label l in hangman )
				l.Visible = false;
		}

		/// <summary>
		/// Disable the guess text box and submit button. Also shows the Play Again button.
		/// </summary>
		void DisableGuessing()
		{
			// disable the ability to make more guesses
			mtxtGuess.Enabled = false;
			btnSubmitGuess.Enabled = false;

			btnReset.Visible = true;    // make play again button visible
		}

		/// <summary>
		/// Draw the next part of the hangman and check if the game is over
		/// </summary>
		void DrawHangman()
		{
			hangman[ nextBodyPart ].Visible = true; // display the next hangman bodypart
			nextBodyPart++; // increase the body part index

			CheckForLoss();	// check for game over
		}

		/// <summary>
		/// Setup the victory screen
		/// </summary>
		void VictoryScreen()
		{
			// inform user they have won the game
			lblError.Text = "You win!!";
			lblError.Visible = true;

			DisableGuessing();
		}

		/// <summary>
		/// Check to see if the game is over
		/// </summary>
		void CheckForLoss()
		{
			if ( nextBodyPart >= hangman.Length )   // if all body parts have been cycled through
			{
				// inform user they have run out of guesses
				lblError.Text = "You have run out of guesses!";
				lblError.Visible = true;

				DisableGuessing();
			}
		}
	}
}
