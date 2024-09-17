// Programmet her skal indlæse brugerens navn og alder,
// og fortælle, hvor gammel vedkommende bliver til næste år.
using System;

Console.WriteLine("Hvad hedder du?");
string navn = Console.ReadLine();

Console.WriteLine("Hvor gammel er du?");
int alder = Convert.ToInt32(Console.ReadLine());

int nyAlder = alder + 1;

Console.WriteLine($"Hej {navn}");
Console.WriteLine($"Til næste år bliver du {nyAlder} år");
