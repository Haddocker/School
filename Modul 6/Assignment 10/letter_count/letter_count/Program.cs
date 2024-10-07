Console.WriteLine("Enter 5 words: ");
string[] words = new string[5];

for (int i = 0; i < words.Length; i++)
{
    words[i] = Console.ReadLine();
}

Console.WriteLine("");

foreach (string word in words)
{
    if (word.Length == 4)
    {
        Console.WriteLine(word);
    }
}