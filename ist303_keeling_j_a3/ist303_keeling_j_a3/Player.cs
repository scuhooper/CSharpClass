using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a3
{
	enum Actions
	{
		eRock,
		ePaper,
		eScissors
	}
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
		Player( string _name )
		{
			Name = _name;
			Wins = 0;
			Losses = 0;
		}
		// play a round of rock, paper, scissors
		void PlayGame( Player p2 )
		{
			Results result;	// variable to store the result of the round
			// run at least one round
			do
			{
				// grab random choice
				Actions p1Choice = (Actions)random.Next( 0, 3 );
				Actions p2Choice = (Actions)random.Next( 0, 3 );

				result = DetermineWinner( p1Choice, p2Choice );	// check for a winner
			}
			while ( result == Results.eDraw );	// keep going until someone wins

			if ( result == Results.ePlayer1Wins )
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

		Results DetermineWinner( Actions action1, Actions action2 )
		{
			if ( action1 == Actions.eRock )
			{
				if ( action2 == Actions.eScissors )
					return Results.ePlayer1Wins;
				else if ( action2 == Actions.ePaper )
					return Results.ePlayer2Wins;
				else
					return Results.eDraw;
			}
			else if ( action1 == Actions.ePaper )
			{
				if ( action2 == Actions.eRock )
					return Results.ePlayer1Wins;
				else if ( action2 == Actions.eScissors )
					return Results.ePlayer2Wins;
				else
					return Results.eDraw;
			}
			else if ( action1 == Actions.eScissors )
			{
				if ( action2 == Actions.ePaper )
					return Results.ePlayer1Wins;
				else if ( action2 == Actions.eRock )
					return Results.ePlayer2Wins;
				else
					return Results.eDraw;
			}
			else
				return Results.eDraw;
		}
	}
}
