using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a4
{
    class Boat : Vessel
    {
        int numOfOars;
        public Boat( int _numOfOars,float _speed, string _name )
            : base( _speed, _name )
        {
            if ( _numOfOars < 1 )
                numOfOars = 1;
            else
                numOfOars = _numOfOars;
        }

        public override void Move()
        {
            Console.WriteLine( "{0} has moved {1} feet.", name, speed * numOfOars );
        }
    }
}
