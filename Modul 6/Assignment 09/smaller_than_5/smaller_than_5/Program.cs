
Console.WriteLine("Enter 5 numbers: ");
double[] numbers = new double[5];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToDouble(Console.ReadLine());
}


Console.WriteLine("");


int smallerThan5 = 0;
foreach (double j in numbers)
{
    if (j < 5)
    {
        smallerThan5++;
    }
}

Console.WriteLine($"{smallerThan5} of your numbers are smaller than 5.");