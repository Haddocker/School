Console.WriteLine("Write the names of three of your friends (press enter after each one): ");
string[] names = new string[3];

for (int i = 0; i < names.Length; i++)
{
    names[i] = Console.ReadLine();
}

// bool containsGoodName = names.Contains("alexander");
// Console.WriteLine("The array contains a good name: " +  containsGoodName);


foreach (string name in names)
{
    if (name == "alexander")
    {
        Console.WriteLine("Nice that you remembered me!");
    }
}