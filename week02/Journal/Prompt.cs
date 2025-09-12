using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    public List<string> prompts =
    ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"];

    public int GeneratePromptNumber()
    {
        Random random = new Random();
        int promptNumber = random.Next(0, prompts.Count);
        return promptNumber;
    }
    public void DisplayPrompt(int promptNumber)
    {
        Console.WriteLine();
        Console.WriteLine(prompts[promptNumber]);
    }

}