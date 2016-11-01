using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ist303_keeling_j_a5
{
	class HangmanGame
	{
		public SortedDictionary<char, bool> lettersGuessed = new SortedDictionary<char, bool>();
		string[] wordBank = File.ReadAllLines( "wordlist.txt" );

		string secretWord;
		string displayedWord;
		bool bIsLetterInWord = false;
		static Random rand = new Random();

		public HangmanGame()
		{
			secretWord = wordBank[ rand.Next( 0, wordBank.Length ) ].ToUpper();
			ResetDisplayedWord();
		}

		public void SubmitGuess( char c )
		{
			bIsLetterInWord = false;
			lettersGuessed.Add( c, true );
			for ( int i = 0; i < secretWord.Length; i++ )
			{
				if ( secretWord[ i ] == c ) {
					string tempStr = displayedWord.Substring( 0, i ) + c + displayedWord.Substring( i + 1, displayedWord.Length - ( i + 1 ) );
					displayedWord = tempStr;
					bIsLetterInWord = true;
				}
			}
		}

		public string PrintDisplayedWord()
		{
			return displayedWord;
		}

		public bool IsLetterInWord()
		{
			return bIsLetterInWord;
		}

		public void Reset()
		{
			secretWord = wordBank[ rand.Next( 0, wordBank.Length ) ].ToUpper();
			ResetDisplayedWord();
			ResetDictionary();
			bIsLetterInWord = false;
		}

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

		void ResetDictionary()
		{
			lettersGuessed = new SortedDictionary<char, bool>();
		}

		public bool CheckForWinner()
		{
			foreach ( char c in displayedWord )
			{
				if ( c == '_' )
					return false;
			}

			return true;
		}
	}
}
