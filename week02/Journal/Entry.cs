public class Entry
{
    public string prompt = "";
    public string response = "";
    public string date = "";

    public void GetResponse(Prompt currentPrompt, int promptNumber)
    {
        response = Console.ReadLine();
        
        prompt = currentPrompt.prompts[promptNumber];

        DateTime currentTime = DateTime.Now;
        date = currentTime.ToShortDateString();
    }
}