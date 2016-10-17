using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a4
{
	class Program
	{
		static void Main( string[] args )
		{
			Ship ship = new Ship( 20, "HMS We Lost in 1776", 4, 5 );
			Ship ship2 = new Ship( 100, "Pharaon", 13, 17 );
			Ship ship3 = new Ship( 1, "Kim Jong-Il's Super Fast Yacht", 0, 1 );
			Boat boat = new Boat( 20, "Boaty McBoatFace", 4 );
			Boat boat2 = new Boat( 4, "Cuban Regufee Raft", 1 );
			Cat cat = new Cat( 3, 5 );

			List<Vessel> vessels = new List<Vessel>();
			vessels.Add( ship );
			vessels.Add( ship.lifeBoat );
			vessels.Add( boat );
			vessels.Add( ship2 );
			vessels.Add( ship2.lifeBoat );
			vessels.Add( boat2 );
			vessels.Add( ship3 );
			vessels.Add( ship3.lifeBoat );			

			foreach ( Vessel ves in vessels ) 
			{
				ves.Move();
			}

			List<IRefillable> refills = new List<IRefillable>();
			refills.Add( ship );
			refills.Add( ship2 );
			refills.Add( ship3 );
			refills.Add( cat );

			ship.PrintFuelPercentage();
			ship2.PrintFuelPercentage();
			ship3.PrintFuelPercentage();
			cat.PrintHungerPercentage();

			foreach ( IRefillable refill in refills ) {
				refill.Refill( 2 );
			}
		}
	}
}
