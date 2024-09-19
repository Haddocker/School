for (int currentBottles = 99; currentBottles > -2; currentBottles--)
{
    int nextBottles = currentBottles - 1;

    if (currentBottles >= 1)
    {
        Console.WriteLine($"{currentBottles} bottles of beer on the wall, {currentBottles} bottles of beer.\n" +
        $"Take one down and pass it around, {nextBottles} bottles of beer on the wall.\n" +
        "");
    }

    else if (currentBottles == 0)
    {
        Console.WriteLine($"{currentBottles} bottles of beer on the wall, {currentBottles} bottles of beer.\n" +
        "Take one down and pass it around, no more bottles of beer on the wall.\n" +
        "");
    }

    else
    {
        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.\n" +
            "");
    }
}