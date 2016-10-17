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

        public float FuelPercentage
        {
            get
            {
                return FuelPercentage;
            }
            set
            {
                if ( value < 0 )
                    value = 0;
                else if ( value > 1 )
                    value = 1;
                FuelPercentage = value;
            }
        }

        public Cat( int _hunger, int _maxHunger )
        {
            hunger = _hunger;
            maxHunger = _maxHunger;

            FuelPercentage = hunger / maxHunger;
        }

        public void Refill( int amount )
        {

        }
    }
}
