
Console.WriteLine("Enter the name of the three goods and their prices: ");
string[] goods = new string[3];
double[] prices = new double[3];

for (int i = 0; i < goods.Length; i++)
{
    Console.Write($"Enter the name of good {i + 1}: ");
    goods[i] = Console.ReadLine();

    Console.Write($"Enter the price of {goods[i]}: ");
    prices[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("");
for  (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{goods[i]} costs {prices[i]} kr.");
}