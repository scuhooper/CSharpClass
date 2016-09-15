using System;

namespace ist303_keeling_j_assignment2
{
	class Vendor
	{
		// array of Items
		public Item[] inventory = new Item[ 5 ];
		bool isShopOpen;	// used to check if we should close the shop inside ShopIsOpen()

		// default constructor. initializes our shop to be open and fills inventory with empty items
		public Vendor()
		{
			for ( int i = 0; i < 5; i++ )
			{
				inventory[ i ] = new Item();
			}
			isShopOpen = true;
		}

		// main function of class. hides the other functions necessary for class to function. serves as an interface function
		public void ShopIsOpen()
		{
			// present the user with basic intro text
			Console.WriteLine( "Welcome to Apocalypse Outfitters!/nWe have all your end-of-the-world needs here under one roof!" );
			while ( isShopOpen )
			{
				PrintInventory();
				int choice = GetChoice();	// get what item the user wants to purchase or if they want to exit
				// user chooses to exit..
				if ( choice == -1 )
				{
					CloseShop();
					continue;	// skip to the end of the loop
				}
				int qty = GetQuantityWanted( choice );	// check quantity user wants of selected item
				if ( qty == 0 )
					continue;	// skip to the end of the loop
				// finalize the sale of the item. prints result of transaction and decrements quantity of item
				MakeSale( choice, qty );
			}
		}

		// give a printout of the store's offerings
		void PrintInventory()
		{
			// easy line num for items to make it easier for user to know what to input for their selection
			int num = 1;

			// reads as "No. Product Name     Price   Qty"
			Console.WriteLine( "{0, -4} {1, -15} {2,8} {3, 5}", "No.", "Product Name", "Price", "Qty" );
			foreach ( Item item in inventory )	// cycle through inventory
			{
				// very ugly way to print necessary info. C is for currency and formats as $#.##
				Console.WriteLine( "{0, -4} {1, -15} {2, 8:C} {3, 5}", num, item.Name, item.Price, item.Quantity );
				num++;
			}
			Console.WriteLine( "Enter -1 if you want to leave." );	// how to leave
		}

		// get user's choice of what to buy or exit
		int GetChoice()
		{
			Console.WriteLine( "To Purchase an item, enter the number at the beginning of the item's entry." );
			int choice;
			int.TryParse( Console.ReadLine(), out choice );	// check if what is entered is actually a number

			if ( choice == -1 )	// user wants to leave, exit function
			{
				return choice;
			}
			if ( choice < 1 || choice > 5 )	// user input is wrong
			{
				Console.WriteLine( "Invalid choice. Please choose again." );
				choice = GetChoice();	// go through choice again
			}

			// returns index of the item as line number starts at 1 but index starts at 0
			return choice - 1;
		}

		// get how many of the item user wants
		int GetQuantityWanted( int choice )
		{
			// get quantity wanted
			Console.WriteLine( "How many would you like?" );
			int numberPurchased;
			bool isNumberValid = int.TryParse( Console.ReadLine(), out numberPurchased );	// check to make sure quantity entered is a number
			// check if user entered an actual number
			while ( !isNumberValid )
			{
				Console.WriteLine( "Please say how many you want as a number. Stop wasting my time." );
				isNumberValid = int.TryParse( Console.ReadLine(), out numberPurchased );
			}
			// did they order more than is in stock?
			if ( numberPurchased > inventory[ choice ].Quantity )
			{
				Console.WriteLine( "Sorry pal. I don't have that many in stock. Pick a different amount." );
				numberPurchased = GetQuantityWanted( choice );
			}
			// did they order less than 0?
			if ( numberPurchased < 0 )
			{
				Console.WriteLine( "Hey! You can't buy a negative amount of {0}!", inventory[ choice ].Name );	// assumes negative number means user does not want that particular item. return to menu
				return 0;
			}

			return numberPurchased;
		}

		// finalize the sale and present neat format to user of what was bought, amount purchased, and total of purchase
		void MakeSale( int choice, int qty )
		{
			// formats as "Here is your quantity item Name for $#.##"
			Console.WriteLine( "Here is your {0} {1} for {2:C}.", qty, inventory[ choice ].Name, qty * inventory[ choice ].Price );
			inventory[ choice ].Quantity = inventory[ choice ].Quantity - qty;	// remove from quantity
			Console.WriteLine( "What else would you like?" );
		}

		// function to exit the while loop and exit shop
		void CloseShop()
		{
			isShopOpen = false;	// changes while loop contingent variable
			Console.WriteLine( "Thanks for coming by. Now beat it." );
		}
	}
}
