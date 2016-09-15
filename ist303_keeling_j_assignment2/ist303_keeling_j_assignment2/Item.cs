using System;

namespace ist303_keeling_j_assignment2
{
	class Item
	{
		double price;
		int quantity;
		string name;

		/// <summary>
		/// Properties for our private variables. Minor checking for negative values for price and quantity as those would not be allowed
		/// </summary>
		public double Price
		{
			get
			{
				return price;
			}
			set
			{
				if ( value > 0 )	// price cannot be negative
					price = value;
			}
		}
		public int Quantity
		{
			get
			{
				return quantity;
			}
			set
			{
				if ( value > 0 )	// quantity cannot be negative
					quantity = value;
			}
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		// default constructor for no args being passed
		public Item()
		{
			price = 0;
			quantity = 0;
			name = "No item";
		}
		// constructor to fully fill out Item's details
		public Item( string _name, double _price, int _quantity )
		{
			name = _name;
			price = _price;
			quantity = _quantity;
		}
	}
}
