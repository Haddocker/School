
Console.WriteLine("Write 3 ingredients you want in your salad (press enter after each one): ");
string[] saladIngredients = new string[3];

for (int i = 0; i < saladIngredients.Length; i++)
{
    saladIngredients[i] = Console.ReadLine();
}

Console.WriteLine("");
for  (int i = 2; i >= 0; i--)
{
    Console.WriteLine(saladIngredients[i]);
}