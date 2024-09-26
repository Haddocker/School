
Console.WriteLine("Enter 5 different numbers: ");
int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("");

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 10)
    {
        Console.WriteLine($"{numbers[i]} is bigger than 10");
    }
}