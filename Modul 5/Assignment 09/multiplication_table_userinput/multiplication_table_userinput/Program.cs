Console.Write("What multiplication table do you want to see (1-10): ");
int table = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for  (int number = 1; number < 11; number++)
{
    Console.WriteLine(number * table);
}