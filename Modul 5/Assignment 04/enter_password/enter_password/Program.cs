int guessCounter = 0;

while (guessCounter < 3)
{
    Console.Write("Write the password here: ");
    string userGuess = Console.ReadLine();

    if (userGuess == "password")
    {
        Console.WriteLine("That is correct!");
        break;
    }
    else
    {
        Console.WriteLine("That is incorrect, try again...");
        guessCounter++;
    }

}