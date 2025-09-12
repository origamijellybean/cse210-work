using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int selection;
        Prompt currentPrompt = new Prompt();
        Entries currentEntries = new Entries();
        Entry currentEntry = new Entry();
        do
        {
            selection = 0;
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            do
            {
                Console.WriteLine("What would you like to do?");
                string rawSelection = Console.ReadLine();
                selection = int.Parse(rawSelection);
            } while (selection > 5 | selection < 1);

            if (selection == 1)
            {
                int promptNumber = currentPrompt.GeneratePromptNumber();
                currentPrompt.DisplayPrompt(promptNumber);
                currentEntry.GetResponse(currentPrompt, promptNumber);
                currentEntries.DuplicateAndAdd(currentEntry);
            }
            else if (selection == 2)
            {
                currentEntries.Display();
            }
            else if (selection == 3)
            {
                //load from file
            }
            else if (selection == 4)
            {
                //save to file
            }
        } while (selection != 5);
    }
}