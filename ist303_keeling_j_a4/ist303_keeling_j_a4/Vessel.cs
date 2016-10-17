using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a4
{
	abstract class Vessel
	{
		protected float speed;
		protected string name;

		public Vessel( float _speed, string _name )
		{
			if ( _speed < 1 )
				_speed = 1;
			
			speed = _speed;
			name = _name;
		}

		/// <summary>
		/// This function should be overridden in descendant classes. Right now it simply prints that the ship's name has moved the distance of the speed in feet
		/// </summary>
		public virtual void Move()
		{
			Console.WriteLine( "{0} has moved {1} knot.", name, speed );
		}
	}
}
