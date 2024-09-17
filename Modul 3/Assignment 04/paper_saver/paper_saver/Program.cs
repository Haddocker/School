Console.WriteLine("How many pages is your document?: ");
int pages = Convert.ToInt32(Console.ReadLine());
var pages_saved = pages / 2;
Console.WriteLine($"You can save {pages_saved} if you print on both sides.");
