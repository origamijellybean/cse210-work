public class BreathingActivity : Activity
{
    private int _breathInTime = 4;
    private int _breathOutTime = 5;
    public BreathingActivity()
    {
        SetActivityType("Breathing");
        SetDescription("This activity helps you relax by practicing breathing in and out. Concentrate on your breathing.");
    }
    public void Breath()
    {
        ActivityStart();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTimeInSeconds());
        DateTime currentTime = DateTime.Now;
        do
        {
            int In = _breathInTime;
            int Out = _breathOutTime;
            Console.Write("\nBreath in...");
            do
            {
                Console.Write(In);
                Thread.Sleep(1000);
                Console.Write($"\b \b");
                In -= 1;
            } while (In > 0);
            Console.Write($"\nAnd breath out...");
            do
            {
                Console.Write(Out);
                Thread.Sleep(1000);
                Console.Write($"\b \b");
                Out -= 1;
            } while (Out > 0);
            currentTime = DateTime.Now;
            Console.WriteLine();
        } while (currentTime < endTime);
        ActivityEnd();
    }
}