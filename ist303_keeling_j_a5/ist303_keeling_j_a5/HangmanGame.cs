using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a5
{
	class HangmanGame
	{
		public SortedDictionary<char, bool> lettersGuessed = new SortedDictionary<char, bool>();

		string secretWord;
		string displayedWord;
		bool bIsLetterInWord = false;

		public HangmanGame()
		{
			secretWord = "HAPPY HALLOWEEN";
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
			ResetDisplayedWord();
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
	}
}
