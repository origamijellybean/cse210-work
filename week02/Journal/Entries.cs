using System.Runtime.InteropServices;

public class Entries
{
    public List<List<string>> entries = [];
    public void Save()
    {

    }
    public void Load()
    {

    }
    public void Display()
    {
        foreach (List<string> entry in entries)
        {
            Console.WriteLine();
            Console.WriteLine(entry[0]);
            Console.WriteLine(entry[1]);
        }
    }
    public void DuplicateAndAdd(Entry currentEntry)
    {
        List<string> newEntry = [];
        newEntry.Add(currentEntry.prompt);
        newEntry.Add(currentEntry.response);
        newEntry.Add(currentEntry.date);
        entries.Add(newEntry);
    }

}