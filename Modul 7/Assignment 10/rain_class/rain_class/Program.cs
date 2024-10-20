using rain_class;

Rain monday = new();
monday.Day = "Monday";
monday.RainAmount = 7;

Rain tuesday = new();
tuesday.Day = "Tuesday";
tuesday.RainAmount = 2;

Weather weather = new();
int totalRain = weather.TotalRainAmount(monday, tuesday);

Console.WriteLine(totalRain);

