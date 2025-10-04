public class ReflectionActivity : Activity
{
    private int _reflectionTime = 124;
    private List<string> _prompts = ["Think of a time when you stood up for someone else.",
                                    "Think of a time when you did something really difficult.",
                                    "Think of a time when you helped someone in need.",
                                    "Think of a time when you did something truly selfless."];

    private List<string> _questions = ["Why was this experience meaningful to you?",
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?",];

    public ReflectionActivity()
    {
        SetActivityType("Reflection");
        SetDescription("This activity helps you relax by giving you prompts for you to reflex on.");
    }
    public string GetRandomItem(List<string> list)
    {
        Random random = new Random();
        int promptNumber = random.Next(0, list.Count);
        return list[promptNumber];
    }

    public void Reflect()
    {
        ActivityStart();
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("Press any key to continue, when you have something in mind.\n");
        Console.ReadKey(intercept: true);
        Console.WriteLine("Now ponder on the following questions as they related to your experience.");

        Console.Write("You may begin in: ");
        int timer = 6;
        do
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write($"\b \b");
            timer -= 1;
        } while (timer > 0);
        Console.Clear();
        Console.WriteLine($"--- {prompt} ---");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimeInSeconds());
        DateTime currentTime = DateTime.Now;
        RandomSelection randomPromptGen = new RandomSelection(_questions);
        string question = randomPromptGen.GetNextItem();
        do
        {

            Console.Write($" > {randomPromptGen.GetNextItem()} ");
            Pause(_reflectionTime);
            Console.WriteLine();
            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        ActivityEnd();


    }


}