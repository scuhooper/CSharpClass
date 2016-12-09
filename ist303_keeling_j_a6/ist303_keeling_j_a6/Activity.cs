using System;

namespace ist303_keeling_j_a6
{
	class Activity
	{
		// variables for a to do list activity
		public DateTime date;
		public string name;

		public Activity( DateTime dt, string actName )	// basic constructor for making activities
		{
			date = dt;
			name = actName;
		}

		// gets easily readable output for reading in the list box control
		public override string ToString()
		{
			return date.ToShortDateString() + " " + date.ToShortTimeString() + " " + name;
		}
	}
}
