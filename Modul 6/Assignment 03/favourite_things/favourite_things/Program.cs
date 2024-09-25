string[] favouriteThings = new string[3];

for (int i = 0; i < favouriteThings.Length; i++)
{
    Console.Write("Type in one of your favourite things: ");
    favouriteThings[i] = Console.ReadLine();
}


Console.WriteLine($"Your favourite things are:\n" +
    $"1: {favouriteThings[0]}\n" +
    $"2: {favouriteThings[1]}\n" +
    $"3: {favouriteThings[2]}");
