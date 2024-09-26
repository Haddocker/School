
Console.WriteLine("How many things do you have to remember?: ");
int number = Convert.ToInt32(Console.ReadLine());

string[] toDoList = new string[number];

for (int i = 0; i < number; i++)
{
    Console.WriteLine($"Enter the thing on your todo list number {i + 1}: ");
    toDoList[i] = Console.ReadLine();
}

Console.WriteLine("");
for (int i = 0; i < number; i++)
{
    Console.WriteLine($"{i + 1}: {toDoList[i]}");
}