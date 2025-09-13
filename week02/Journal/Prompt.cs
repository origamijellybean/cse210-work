using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    public List<string> prompts =
    ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What is a childhood memory you can remember from today?",
    "What is one lesson you could teach your future family?",
    "What is a life lesson you learned today?",
    "What was something good you did for someone today?",
    "What was something good someone did for you today?",
    "What is something happening in your life right now?"];

    public string GeneratePrompt()
    {
        Random random = new Random();
        int promptNumber = random.Next(0, prompts.Count);
        return prompts[promptNumber];
    }
}