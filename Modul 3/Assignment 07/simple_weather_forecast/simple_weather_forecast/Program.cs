Console.Write("How is the weather right now? Sunny, rainy or gray?: ");
string weather_status = Console.ReadLine();

Console.Write("How hot is it right now in celsius?: ");
int weather_celsius = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"It is {weather_status} and {weather_celsius}° right now!");