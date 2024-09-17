const string good_name = "alexander";

Console.Write("What is your name?: ");
string user_name = Console.ReadLine().ToLower();

if (user_name == good_name)
{
    Console.WriteLine("Wow that is a beautiful name!");
}
else
{
    Console.WriteLine("That's an okay name...");
}