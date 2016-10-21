using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a4
{
	class Ship : Vessel, IRefillable
	{
		int fuel, maxFuel;
		float fuelPercentage;
		public Boat lifeBoat;

        public float FuelPercentage
        {
            get
            {
                return (float)fuel / (float)maxFuel;
            }
        }

		public Ship( float _speed, string _name, int _fuel, int _maxFuel )
			: base( _speed, _name )
		{
			fuel = _fuel;
			if ( fuel < 0 )
				fuel = 0;

			maxFuel = _maxFuel;
			if ( maxFuel < 1 )
				maxFuel = 1;

			lifeBoat = new Boat( 5, name + "'s lifeboat", 2 );
		}

		public override void Move()
		{
			if ( fuel > 0 )
			{
				fuel--;
				Console.WriteLine( "{0} has moved {1} knots. It has {2:P} fuel remaining.", name, speed, FuelPercentage );
			}
			else
				Console.WriteLine( "{0} is out of fuel!", name );
		}

		public void PrintFuelPercentage() 
		{
			Console.WriteLine( "{0} has {1:P} fuel remaining.", name, FuelPercentage );
		}

        public void Refill( int amount )
        {
			if ( amount < 0 )
				amount = 0;
			else if ( amount > maxFuel - fuel )
				amount = maxFuel - fuel;

            fuel += amount;

			Console.WriteLine( "{0} refilled {1} fuel and now has {2:P} fuel remaining.", name, amount, FuelPercentage );
        }
	}
}
