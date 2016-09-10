using System;

namespace ist303_keeling_j_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
			Vendor shop = new Vendor();
			shop.inventory[ 0 ] = new Item( "Medkit", 75, 10 );
			shop.inventory[ 1 ] = new Item( "Body Armour", 200, 2 );
			shop.inventory[ 2 ] = new Item( "Assault Rifle", 600, 1 );
			shop.inventory[ 3 ] = new Item( "Shotgun", 400, 3 );
			shop.inventory[ 4 ] = new Item( "Pretty Rock", 2.5, 1 );

			shop.ShopIsOpen();
        }
    }
}
