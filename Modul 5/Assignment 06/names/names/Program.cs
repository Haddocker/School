List<string> participantNames = [];
string names;

do
{
    Console.Write("Write the names of the participant (if you're done press 'enter' key): ");
    names = Console.ReadLine();

    // Stops the script from adding "Enter Key - Blank Space" as a participant. 
    if (!string.IsNullOrEmpty(names))
    {
        participantNames.Add(names);
    }

} while (!string.IsNullOrEmpty(names));

Console.WriteLine("Participants: " + string.Join(", ", participantNames));