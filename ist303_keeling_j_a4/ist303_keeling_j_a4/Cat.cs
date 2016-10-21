using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a4
{
    class Cat : IRefillable
    {
        int hunger, maxHunger;
		float fuelPercentage;

        public float FuelPercentage
        {
            get
            {
				return (float)hunger / (float)maxHunger;
            }
        }

        public Cat( int _hunger, int _maxHunger )
        {
            hunger = _hunger;
            maxHunger = _maxHunger;
        }

		public void PrintHungerPercentage() {
			Console.WriteLine( "Cat is now {0:P} hungry.", FuelPercentage );
		}

        public void Refill( int amount )
        {
			if ( amount < 0 )
				amount = 0;
			else if ( amount > hunger )
				amount = hunger;

			hunger -= amount;

			Console.WriteLine( "Cat ate {0} morsels of food and is now {1:P} hungry.", amount, FuelPercentage );
        }
    }
}
