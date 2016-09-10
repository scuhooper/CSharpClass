using System;

namespace ist303_keeling_j_assignment2
{
	class Item
	{
		double price;
		int quantity;
		string name;

		public Item()
		{
			price = 0;
			quantity = 0;
			name = "No item";
		}
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
