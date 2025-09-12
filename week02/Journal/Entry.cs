public class Entry
{
    public string prompt = "";
    public string response = "";
    public string date = "";

    public void GetEntry(string currentPrompt)
    {
        response = Console.ReadLine();

        prompt = currentPrompt;

        DateTime currentTime = DateTime.Now;
        date = currentTime.ToShortDateString();
    }
}