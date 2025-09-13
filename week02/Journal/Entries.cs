using System.Runtime.InteropServices;
using System.IO;

public class Entries
{
    public List<List<string>> entries = [];
    public string fileName = "";
    public void Save()
    {
        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();
        using (StreamWriter saveFile = new StreamWriter(fileName))
        {
            foreach (List<string> entry in entries)
        {
            saveFile.WriteLine($"{entry[0]}|{entry[1]}|{entry[2]}");
        }
        }
    }
    public void Load()
    {
        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();
        entries = [];
        string[] rawJournal = System.IO.File.ReadAllLines(fileName);
        foreach (string rawEntry in rawJournal)
        {
            string[] parts = rawEntry.Split("|");
            entries.Add([parts[0], parts[1], parts[2]]);
        }
        Display();
    }
    public void Display()
    {
        foreach (List<string> entry in entries)
        {
            Console.WriteLine();
            Console.WriteLine($"{entry[2]}: {entry[0]}");
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