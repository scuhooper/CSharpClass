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

		public HangmanGame()
		{
			lettersGuessed.Add( 'A', false );
			lettersGuessed.Add( 'B', false );
			lettersGuessed.Add( 'C', false );
			lettersGuessed.Add( 'D', false );
			lettersGuessed.Add( 'E', false );
			lettersGuessed.Add( 'F', false );
			lettersGuessed.Add( 'G', false );
			lettersGuessed.Add( 'H', false );
			lettersGuessed.Add( 'I', false );
			lettersGuessed.Add( 'J', false );
			lettersGuessed.Add( 'K', false );
			lettersGuessed.Add( 'L', false );
			lettersGuessed.Add( 'M', false );
			lettersGuessed.Add( 'N', false );
			lettersGuessed.Add( 'O', false );
			lettersGuessed.Add( 'P', false );
			lettersGuessed.Add( 'Q', false );
			lettersGuessed.Add( 'R', false );
			lettersGuessed.Add( 'S', false );
			lettersGuessed.Add( 'T', false );
			lettersGuessed.Add( 'U', false );
			lettersGuessed.Add( 'V', false );
			lettersGuessed.Add( 'W', false );
			lettersGuessed.Add( 'X', false );
			lettersGuessed.Add( 'Y', false );
			lettersGuessed.Add( 'Z', false );
		}

		public void SubmitGuess( char c )
		{
			lettersGuessed[ c ] = true;
		}
	}
}
