Random random = new Random();

int randomNumber = random.Next(1, 10);
// Console.WriteLine($"pssst the correct number is: {randomNumber}");

Console.Write("See if you can guess the random number (between 1 and 10): ");
int userGuess;

do
{
    Console.Write("That was wrong try again: ");
    userGuess = Convert.ToInt32(Console.ReadLine());
} while (userGuess != randomNumber);

Console.WriteLine("That's correct!");