using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ist303_keeling_j_a3
{
    // enum class to track which choice was performed
	enum Actions
	{
		eRock,
		ePaper,
		eScissors
	}
    // enum class to keep who won or if the game was a draw
	enum Results
	{
		eDraw,
		ePlayer1Wins,
		ePlayer2Wins
	}
	class Player
	{
		string name;
		int wins, losses;
		static Random random = new Random();	// static so random will have different values in case multiple players are instantiated at the same time

		// properties
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int Wins
		{
			get { return wins; }
			set { wins = value; }
		}
		public int Losses
		{
			get { return losses; }
			set { losses = value; }
		}

		// constructor that only takes a parameter for the name of the player. Wins and Losses are always 0 when a player is created
		public Player( string _name )
		{
			Name = _name;
			Wins = 0;
			Losses = 0;
		}
		// play a round of rock, paper, scissors
		public void PlayGame( Player p2 )
		{
			Results result;	// variable to store the result of the round
			// run at least one round
			do
			{
				// grab random choice
				Actions p1Choice = (Actions)random.Next( 0, 3 );
				Actions p2Choice = (Actions)random.Next( 0, 3 );

				result = DetermineWinner( p1Choice, p2Choice );	// check for a winner
				PrintGameDetails( this, p2, p1Choice, p2Choice, result );
				Thread.Sleep( 1000 );	// wait one second before continuing
				
			}
			while ( result == Results.eDraw );	// keep going until someone wins

			if ( result == Results.ePlayer1Wins )   // update the wins and losses for both players according to who won
			{
				this.Wins++;
				p2.Losses++;
			}
			else
			{
				this.Losses++;
				p2.Wins++;
			}
		}
        
        // figure out winner based on the actions chosen. return draw or who won
		Results DetermineWinner( Actions action1, Actions action2 )
		{
			if ( action1 == Actions.eRock ) // player1 is rock
			{
				if ( action2 == Actions.eScissors )
					return Results.ePlayer1Wins;
				else if ( action2 == Actions.ePaper )
					return Results.ePlayer2Wins;
				else
					return Results.eDraw;
			}
			else if ( action1 == Actions.ePaper )   // player1 is paper
			{
				if ( action2 == Actions.eRock )
					return Results.ePlayer1Wins;
				else if ( action2 == Actions.eScissors )
					return Results.ePlayer2Wins;
				else
					return Results.eDraw;
			}
			else if ( action1 == Actions.eScissors )    // player1 is scissors
			{
				if ( action2 == Actions.ePaper )
					return Results.ePlayer1Wins;
				else if ( action2 == Actions.eRock )
					return Results.ePlayer2Wins;
				else
					return Results.eDraw;
			}
			else
				return Results.eDraw;   // nothing should reach this point, but if it does, redo the round
		}

		// output the details of each round to the screen. Tell who did what, and who, if anyone, won
		void PrintGameDetails( Player p1, Player p2, Actions action1, Actions action2, Results result ) {
			Console.WriteLine( "{0} chose {1}! {2} chose {3}!", p1.Name, ActionToString( action1 ), p2.Name, ActionToString( action2 ) );
			Console.WriteLine( ResultToString( p1, p2, result ) );
			Console.WriteLine();
		}

		// simply converts the action enum into its string equivalent
		string ActionToString( Actions action ) {
			string actionString;
			if ( action == Actions.ePaper ) {
				actionString = "paper";
				return actionString;
			}
			else if ( action == Actions.eRock ) {
				actionString = "rock";
				return actionString;
			}
			else {
				actionString = "scissors";
				return actionString;
			}
		}

		// converts the Results enum to the string equivalent
		string ResultToString( Player p1, Player p2, Results result ) {
			string strResult;

			if ( result == Results.eDraw ) {
				strResult = "DRAW!";
				return strResult;
			}
			else if ( result == Results.ePlayer1Wins ) {
				strResult = p1.Name + " wins!";
				return strResult;
			}
			else {
				strResult = p2.Name + " wins!";
				return strResult;
			}
		}
	}
}
