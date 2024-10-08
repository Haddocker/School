class Program
{
    static void Main(string[] args)
    {

        // Main menu items and prices
        var mainMenu = new (string, double)[]
        {
            ("Almindelig kaffe", 6.00),
            ("Latte macchiato", 9.00),
            ("Cappuccino", 6.00),
            ("Espresso", 6.00),
            ("The", 5.00),
            ("Cacao", 7.00),
            ("Suppe", 7.00)
        };


        // Additional menu items and prices
        var additionalMenu = new (string, double)[]
        {
            ("Fløde", 1.00),
            ("Sukker", 1.00),
            ("Flødeskum", 1.00)
        };


        // Drinks that can have cream, sugar, or whipped cream
        var drinksWithCream = new[] { "Almindelig kaffe", "Cappuccino", "Espresso", "The" };
        var drinksWithSugar = new[] { "Latte macchiato", "Almindelig kaffe", "Cappuccino", "Espresso", "The" };
        var drinksWithWhippedCream = new[] { "Cacao" };


        // Welcome intro / print menu
        Console.Write("Welcome to the Coffee Machine!\nHere is the menu:\n" +
            "Drink                      Price\n" +
            "---------------------------------\n");

        for (int i = 0; i < mainMenu.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {mainMenu[i].Item1,-20} {mainMenu[i].Item2,5} kr.");
        }


        // Ask for user input
        int choice = 0;
        bool itemExists = false;
        while (itemExists is false)
        {
            Console.WriteLine("\nWhat would you like to order? (Enter the number of the item): ");
            choice = Convert.ToInt32(Console.ReadLine()) - 1;

            // Catch incorrect/out of bound input
            if (choice < 0 || choice > mainMenu.Length)
            {
                Console.WriteLine("Sorry, that item is not available. Please pick an item from the menu.");
            }
            else
            {
                itemExists = true;
            }
        }


        // Selected drink and its price
        string drink = mainMenu[choice].Item1;
        double price = mainMenu[choice].Item2;


        // Ask for extras if available
        if (drinksWithCream.Contains(drink))
            price = AddExtra("cream", additionalMenu[0].Item2, price);

        if (drinksWithSugar.Contains(drink))
            price = AddExtra("sugar", additionalMenu[1].Item2, price);

        if (drinksWithWhippedCream.Contains(drink))
            price = AddExtra("whipped cream", additionalMenu[2].Item2, price);



        static double AddExtra(string extraName, double extraPrice, double currentPrice)
        {
            Console.WriteLine($"\nWould you like to add {extraName} to your drink for an extra {extraPrice} kr.? (yes/no): ");
            string choice = Console.ReadLine().ToLower();

            // Check for valid input
            while (choice != "yes" && choice != "no")
            {
                Console.WriteLine("Please enter 'yes' or 'no': ");
                choice = Console.ReadLine()?.ToLower();
            }

            if (choice == "yes")
            {
                Console.WriteLine($"You have added {extraName} to your order.\n");
                currentPrice += extraPrice;
            }

            return currentPrice;
        }


        // Order up!
        Console.WriteLine($"Your order is: {drink}\nAnd your total price is: {price} kr.");
    }
}
