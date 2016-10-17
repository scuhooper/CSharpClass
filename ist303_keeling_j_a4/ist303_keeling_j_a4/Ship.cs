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

		public Ship( float _speed, string _name, int _fuel, int _maxFuel )
			: base( _speed, _name )
		{
			fuel = _fuel;
			if ( fuel < 0 )
				fuel = 0;
			maxFuel = _maxFuel;
			if ( maxFuel < 1 )
				maxFuel = 1;

            FuelPercentage = fuel / maxFuel;
		}

		public override void Move()
		{
			if ( fuel > 0 )
			{
				Console.WriteLine( "{0} has moved {1} feet. It has {2} fuel remaining.", name, speed, fuel );
			}
		}

        public void Refill( int amount )
        {
            if ( amount < 0 )
                amount = 0;

            fuel += amount;
            if ( fuel > maxFuel )
                fuel = maxFuel;
        }
	}
}
