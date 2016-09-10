using System;

namespace ist303_keeling_j_assignment2
{
	class Item
	{
		double price;
		int quantity;
		string name;

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

		/// accessors
		public double GetPrice()
		{
			return price;
		}
		public void SetPrice( double _price )
		{
			price = _price;
		}
		public int GetQuantity()
		{
			return quantity;
		}
		public void SetQuantity( int _quantity )
		{
			quantity = _quantity;
		}
		public string GetName()
		{
			return name;
		}
		public void SetName( string _name )
		{
			name = _name;
		}
	}
}
