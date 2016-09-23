using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a3
{
	class Program
	{
		static void Main( string[] args ) {
			// not needed
			//bool bIsAddingPlayer = true;
			//List<string> nameList = new List<string>();
			//while ( bIsAddingPlayer ) {
			//	Console.WriteLine( "Enter the name of the player to be added to the game:" );
			//	string tempName = Console.ReadLine();
			//	nameList.Add( tempName );

			//	Console.WriteLine( "There are {0} players right now. A minimum of 2 is needed to play.", players.Count() );
			//	Console.WriteLine( "Would you like to add another player? Enter y/n" );
			//	char choice;
			//	char.TryParse( Console.ReadLine(), out choice );
			//	char.ToLower( choice );

			//	if ( choice == 'y' )
			//		bIsAddingPlayer = true;
			//	else
			//		bIsAddingPlayer = false;
			//}

			// names of players. can input more as long as they are then added to the GetPlayerNames function
			string name1 = "Geralt";
			string name2 = "Edmond Dantes";
			string name3 = "James Bond";
			string name4 = "Lara Croft";
			string name5 = "Peter Griffin";

			// create list based on name# variables
			List<Player> players = GetPlayerNames( name1, name2, name3, name4, name5 );
			List<Player> alreadyPlayed = new List<Player>();	// empty list to hold players after they have finished their hands

			// not sure if this is faster than using nested for loops (for example: int i=0, and int j=1)
			// while loop to cycle through one player playing all remaining players before being sent to alreadyPlayed
			while ( players.Count > 1 ) {	// while we still have 2 players waiting to play
				for ( int i = 1; i < players.Count; i++ ) {
					players[0].PlayGame( players[i] );	// play a round until there is a winner
				}
				alreadyPlayed.Add( players[0] );	// add player to already played list
				players.Remove( players[0] );	// remove player from the active players list
			}
			// add and remove one last time to get the player who was at the end of the list originally
			alreadyPlayed.Add( players[0] );
			players.Remove( players[0] );

			// LINQ to generate an array where players are sorted based on the total number of wins
			var listSortedByWins = from player in alreadyPlayed orderby player.Wins descending select player;
			// step through array and print the results
			foreach ( Player player in listSortedByWins ) {
				Console.WriteLine( "{0} has {1} wins and {2} losses.", player.Name, player.Wins, player.Losses );
			}

			Console.WriteLine();	// needed for spacing and ease of reading the output

			// LINQ to generate an array where players have same number of wins and losses
			var EqualWinLoss = from player in alreadyPlayed where player.Wins == player.Losses select player;
			// step through array and print the results
			foreach ( Player player in EqualWinLoss ) {
				Console.WriteLine( "{0} has an equal amount wins and losses.", player.Name );
			}
		}

		// function to take in unlimited names as strings and create a singular list of players from them. Returns the list of players.
		static List<Player> GetPlayerNames( params string[] list ){
			List<Player> tempList = new List<Player>();
			foreach ( string name in list ) {
				tempList.Add( new Player( name ) );
			}
			return tempList;
		}
	}
}
