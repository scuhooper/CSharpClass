using System;

namespace ist303_keeling_j_assignment2
{
	class Vendor
	{
		public Item[] inventory = new Item[ 5 ];
		bool isShopOpen;

		public Vendor()
		{
			for ( int i = 0; i < 5; i++ )
			{
				inventory[ i ] = new Item();
			}
			isShopOpen = true;
		}

		public void ShopIsOpen()
		{
			Console.WriteLine( "Welcome to Apocalypse Outfitters!/nWe have all your end-of-the-world needs here under one roof!" );
			while ( isShopOpen )
			{
				PrintInventory();
				int choice = GetChoice();
				if ( choice == -1 )
				{
					CloseShop();
					continue;
				}
				int qty = GetQuantityWanted( choice );
				if ( qty == 0 )
					continue;
				MakeSale( choice, qty );

			}
		}

		void PrintInventory()
		{
			int num = 1;
			Console.WriteLine( "{0, -4} {1, -15} {2,8} {3, 5}", "No.", "Product Name", "Price", "Qty" );
			foreach ( Item item in inventory )
			{
				Console.WriteLine( "{0, -4} {1, -15} {2, 8:C} {3, 5:D}", num, item.GetName(), item.GetPrice(), item.GetQuantity() );
				num++;
			}
			Console.WriteLine( "Enter -1 if you want to leave." );
		}

		int GetChoice()
		{
			Console.WriteLine( "To Purchase an item, enter the number at the beginning of the item's entry." );
			int choice;
			int.TryParse( Console.ReadLine(), out choice );

			if ( choice == -1 )
			{
				return choice;
			}
			if ( choice < 1 || choice > 5 )
			{
				Console.WriteLine( "Invalid choice. Please choose again." );
				choice = GetChoice();
			}

			return choice - 1;
		}

		int GetQuantityWanted( int choice )
		{
			// get quantity wanted
			Console.WriteLine( "How many would you like?" );
			int numberPurchased;
			bool isNumberValid = int.TryParse( Console.ReadLine(), out numberPurchased );
			// check if user entered an actual number
			while ( !isNumberValid )
			{
				Console.WriteLine( "Please say how many you want as a number. Stop wasting my time." );
				isNumberValid = int.TryParse( Console.ReadLine(), out numberPurchased );
			}
			// did they order more than is in stock?
			if ( numberPurchased > inventory[ choice ].GetQuantity() )
			{
				Console.WriteLine( "Sorry pal. I don't have that many in stock. Pick a different amount." );
				numberPurchased = GetQuantityWanted( choice );
			}
			// did they order less than 0?
			if ( numberPurchased < 0 )
			{
				Console.WriteLine( "Hey! You can't buy a negative amount of {0}!", inventory[ choice ].GetName() );
				return 0;
			}

			return numberPurchased;
		}

		void MakeSale( int choice, int qty )
		{
			Console.WriteLine( "Here is your {0} {1} for {2:C}.", qty, inventory[ choice ].GetName(), qty * inventory[ choice ].GetPrice() );
			inventory[ choice ].SetQuantity( inventory[ choice ].GetQuantity() - qty );
			Console.WriteLine( "What else would you like?" );
		}

		void CloseShop()
		{
			isShopOpen = false;
			Console.WriteLine( "Thanks for coming by. Now beat it." );
		}
	}
}
