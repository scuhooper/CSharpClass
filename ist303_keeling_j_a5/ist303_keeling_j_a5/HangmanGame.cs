using System;
using System.Collections.Generic;
using System.IO;

namespace ist303_keeling_j_a5
{
	class HangmanGame
	{
		// hashtable for storing what characters have already been guessed
		public SortedDictionary<char, bool> lettersGuessed = new SortedDictionary<char, bool>();
		string[] wordBank = File.ReadAllLines( "wordlist.txt" );	// text file for strings of only characters for use in the game

		string secretWord;	// word to be guessed
		string displayedWord;	// string that shows the user what letters from the secret word have been guessed
		bool bIsLetterInWord = false;	// boolean to keep track if a guessed letter is correct
		static Random rand = new Random();	// create a Random value to be shared by all game objects

		public HangmanGame()
		{
			secretWord = wordBank[ rand.Next( 0, wordBank.Length ) ].ToUpper();	// initialize the secret word with a random string from the text file, string is converted to all uppercase
			ResetDisplayedWord();	// Reset the displayed word to be blank with same amount of characters as the secret word
		}

		/// <summary>
		/// Check to see if a submitted character is in the secret word
		/// </summary>
		/// <param name="c">Letter to check if it is in the secret word</param>
		public void SubmitGuess( char c )
		{
			bIsLetterInWord = false;	// set default value for the letter in the word to be incorrect
			lettersGuessed.Add( c, true );	// add the letter to the hashtable

			// check through the letters of secret word
			for ( int i = 0; i < secretWord.Length; i++ )
			{
				if ( secretWord[ i ] == c ) {   // if the letter of secret word matches the guessed letter
					// create a string from the first part of the displayed string, add the new character to the current position, then add the rest of the displayed string to the new string
					string tempStr = displayedWord.Substring( 0, i ) + c + displayedWord.Substring( i + 1, displayedWord.Length - ( i + 1 ) );
					displayedWord = tempStr;	// set our displayed string to our newly created string
					bIsLetterInWord = true;	// the letter is a correct guess
				}
			}
		}

		/// <summary>
		/// Returns the displayed word
		/// </summary>
		/// <returns></returns>
		public string GetDisplayedWord()
		{
			return displayedWord;
		}

		/// <summary>
		/// Returns if the last guessed letter was in the secret word
		/// </summary>
		/// <returns></returns>
		public bool IsLetterInWord()
		{
			return bIsLetterInWord;
		}

		/// <summary>
		/// Resets the game with a new secret word, changes the displayed word to match the new secret word, and clears the guessed letters hashtable
		/// </summary>
		public void Reset()
		{
			secretWord = wordBank[ rand.Next( 0, wordBank.Length ) ].ToUpper();	// get new random string from file for secret word
			ResetDisplayedWord();
			ResetDictionary();
			bIsLetterInWord = false;
		}

		/// <summary>
		/// Resets displayed word to be same length as secret word but with underscores in place of letters
		/// </summary>
		void ResetDisplayedWord()
		{
			displayedWord = "";
			foreach ( char c in secretWord )
			{
				if ( c != ' ' )
					displayedWord += '_';
				else
					displayedWord += ' ';
			}
		}

		/// <summary>
		/// Resets the SortedDictionary or hashtable of guessed letters to a new, empty hashtable
		/// </summary>
		void ResetDictionary()
		{
			lettersGuessed = new SortedDictionary<char, bool>();
		}

		/// <summary>
		/// Checks if all characters in the displayed word have been guessed
		/// </summary>
		/// <returns>Returns true if game has been won</returns>
		public bool CheckForWinner()
		{
			foreach ( char c in displayedWord )
			{
				if ( c == '_' )
					return false;	// if any underscores are still in the displayed word, the game has not been won
			}

			return true;
		}
	}
}
