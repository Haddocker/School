
for (int line = 1; line < 11; line++)
{
    for (int number = line; number < line * 10 + 1; number = number + line)
    {
        Console.Write($" {number,3} |");
    }
    Console.WriteLine("\n------------------------------------------------------------");
}