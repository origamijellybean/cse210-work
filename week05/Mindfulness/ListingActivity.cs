public class ListingActivity : Activity
{
    private List<string> _prompts = ["List ways you helped others today:",
                                    "List ways others helped you today:",
                                    "List ways you saw God's hand in your life today:",
                                    "Lists good things about a family member:",
                                    "Who are people that you appreciate?",
                                    "What are personal strengths of yours?",
                                    "Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?",
                                    "Who are some of your personal heroes?"];
    private int _numItems = 0;

    public ListingActivity()
    {
        SetActivityType("Listing");
        SetDescription("This activity helps you relax by giving you time to write down things on your mind.");
    }

    public string GetRandomPrompt(List<string> prompt)
    {
        Random random = new Random();
        int promptNumber = random.Next(0, prompt.Count);
        return prompt[promptNumber];
    }

    public void List()
    {
        ActivityStart();
        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt(_prompts)} ---\n");
        Console.Write("You may begin in: ");
        int timer = 6;
        do
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write($"\b \b");
            timer -= 1;
        } while (timer > 0);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimeInSeconds());
        DateTime currentTime = DateTime.Now;
        do
        {
            Console.Write($" > ");
            Console.ReadLine();
            _numItems += 1;
            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        Console.WriteLine($"You listed {_numItems} items!");
        ActivityEnd();

    }
}