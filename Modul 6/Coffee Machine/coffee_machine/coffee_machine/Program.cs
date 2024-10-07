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

// Drinks that can have cream, sugar or whipped cream
var drinksWithCream = new[] {"Almindelig kaffe", "Cappuccino", "Espresso", "The"};
var drinksWithSugar = new[] {"Latte macchiato", "Almindelig kaffe", "Cappuccino", "Espresso", "The"};
var drinksWithWhippedCream = new[] {"Cacao"};



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
    Console.WriteLine("\nWhat would you like to order?: ");
    choice = Convert.ToInt32(Console.ReadLine()) - 1;

    // Catch incorrect/out of bound input
    if (choice < 0 || choice >= mainMenu.Length)
    {
        Console.WriteLine("Sorry but that item is not avaiable. Please pick an item on the menu.");
    }
    else
    {
        itemExists = true;
    }
}

// Convert ChoiceInt into an item with a price from mainMenu array
string drink = mainMenu[choice].Item1;
double price = mainMenu[choice].Item2;



// Check if users drink can have additional ingredients
bool addCream = drinksWithCream.Contains(drink);
bool addSugar = drinksWithSugar.Contains(drink);
bool addWhippedCream = drinksWithWhippedCream.Contains(drink);

// Check if user want cream and add extras to price
if (addCream)
{
    Console.WriteLine($"\nWould you like to add cream to your drink for an extra {additionalMenu[0].Item2} kr.? (yes/no): ");
    string creamChoice = Console.ReadLine().ToLower();
    if (creamChoice == "yes")
    {
        Console.WriteLine("You have added cream to your order.\n");
        price += additionalMenu[0].Item2;
    }
}

// Check if user want sugar and add extras to price
if (addSugar)
{
    Console.WriteLine($"Would you like to add sugar to your drink for an extra {additionalMenu[1].Item2} kr.? (yes/no): ");
    string sugarChoice = Console.ReadLine().ToLower();
    if (sugarChoice == "yes")
    {
        Console.WriteLine("You have added sugar to your order.\n");
        price += additionalMenu[1].Item2;
    }
}

// Check if user want whipped cream and add extras to price
if (addWhippedCream)
{
    Console.WriteLine($"Would you like to add whipped cream to your drink for an extra {additionalMenu[2].Item2} kr.? (yes/no): ");
    string WhippedCreamChoice = Console.ReadLine().ToLower();
    if (WhippedCreamChoice == "yes")
    {
        Console.WriteLine("You have added whipped cream to your order.\n");
        price += additionalMenu[2].Item2;
    }
}



// Order up!
Console.WriteLine($"Your order is: {drink}" +
    $"\nAnd your total price is: {price} kr.");