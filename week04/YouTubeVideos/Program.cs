using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];
        Video uno = new Video("Uno game between me and cousin", "Fred Stewart", 201);
        videos.Add(uno);
        uno.EnterComment("Fred", "Mattel is such a boring company!");
        uno.EnterComment("Jack", "Seriously! Dos is a lame game!");
        uno.EnterComment("Fred", "And they don't allow house rules in Uno!");
        uno.EnterComment("Jack", "The only redeeming quality is Uno is a classic.");
        Video hotWheels = new Video("My Hot Wheels speedrun!", "Donald Trump", 1000);
        videos.Add(hotWheels);
        hotWheels.EnterComment("Trump", "I remember playing with my HotWheels as a kid!");
        hotWheels.EnterComment("Trump", "There are so many vehicles they have, I'll never get bored!");
        hotWheels.EnterComment("Trump", "Mattel is so much cooler than Matchbox.");
        Video fisherCube = new Video("Fisher Cube unboxing", "Stef Curry", 305);
        videos.Add(fisherCube);
        fisherCube.EnterComment("Stef", "Fun fact, FisherPrice is actually owned by Mattel.");
        fisherCube.EnterComment("Stef", "FisherPrice always has made cool stuff, no wonder Mattel bought the company!");
        fisherCube.EnterComment("Stef", "Mattel also bought Barbie, although that's a lame franchise to own.");
        Console.WriteLine($"Number of videos: {videos.Count()}\n");
        int counter1 = 0;
        foreach (Video vid in videos)
        {
            counter1 += 1;
            Console.WriteLine($"Video {counter1}: {vid.GetTitle()}");
            Console.WriteLine($"Author: {vid.GetAuthor()}");
            TimeSpan time = TimeSpan.FromSeconds(vid.GetLength());
            Console.WriteLine($"Length: {time.Minutes}:{time.Seconds:D2}");
            Console.WriteLine($"Number of comments: {vid.GetNumComments()}");
            int counter2 = 0;
            foreach (Comment comment in vid.GetComments())
            {
                counter2 += 1;
                Console.WriteLine($"Comment {counter2} ({comment.GetName()}):");
                Console.WriteLine($"{comment.GetText()}\n");
            }
            Console.WriteLine();
        }
    }
}