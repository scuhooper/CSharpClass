using System;

namespace ist303_keeling_j_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
			Item item = new Item();
			Vendor vendor = new Vendor();
			item.SetName( "Snickers" );
			item.SetPrice( .80 );
			item.SetQuantity( 12 );

			Console.WriteLine( "{0, -15} {1,8} {2, 5}", "Product Name", "Price", "Qty" );
			Console.WriteLine( "{0, -15} {1, 8:C} {2, 5:D}", item.GetName(), item.GetPrice(), item.GetQuantity() );
        }
    }
}
