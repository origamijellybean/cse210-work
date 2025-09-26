using System;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        Order games = new Order();
        games.SetName("Fred Simpson");
        games.SetAddress("555 Middle", "Nowhere", "West", "United States");
        games.AddProduct("Mario bros.", 01, 50.00, 1);
        games.AddProduct("Zelda DS", 02, 15.99, 1);
        games.AddProduct("Dice set", 03, 4.49, 11);

        Order sports = new Order();
        sports.SetName("John Sina");
        sports.SetAddress("502 State Street", "Miami", "Florida", "Mexico");
        sports.AddProduct("Football", 07, 199.99, 1);
        sports.AddProduct("Soccer Ball", 03, 20.00, 3);


        Console.WriteLine();
        string gamesShippingString = games.ShippingLabel();
        string[] gamesShippingLabel = gamesShippingString.Split(";");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Customer: {gamesShippingLabel[0]}");
        Console.WriteLine($"Address: {gamesShippingLabel[1]}");

        string gamesPackingString = games.PackingLabel();
        string[] gamesPackingList = gamesPackingString.Split(";");
        List<List<string>> gamesPackingLabel = new List<List<string>>();
        Console.WriteLine("Packing Label:");
        foreach (string item in gamesPackingList)
        {
            gamesPackingLabel.Add(item.Split(",").ToList());
            Console.WriteLine($"{gamesPackingLabel[gamesPackingLabel.Count - 1][1]}: {gamesPackingLabel[gamesPackingLabel.Count - 1][0]}, Price each: ${gamesPackingLabel[gamesPackingLabel.Count - 1][2]:F2}, Quantity: {gamesPackingLabel[gamesPackingLabel.Count-1][3]}");
        }
        List<double>gamesOrderCost = games.CalculateOrderCost();
        Console.WriteLine($"Shipping: ${gamesOrderCost[1]:F2}");
        Console.WriteLine($"Total Cost: ${(gamesOrderCost[0]+gamesOrderCost[1]):F2}");

        Console.WriteLine();
        string sportsShippingString = sports.ShippingLabel();
        string[] sportsShippingLabel = sportsShippingString.Split(";");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Customer: {sportsShippingLabel[0]}");
        Console.WriteLine($"Address: {sportsShippingLabel[1]}");
        
        string sportsPackingString = sports.PackingLabel();
        string[] sportsPackingList = sportsPackingString.Split(";");
        List<List<string>> sportsPackingLabel = new List<List<string>>();
        Console.WriteLine("Packing Label:");
        foreach (string item in sportsPackingList)
        {
            sportsPackingLabel.Add(item.Split(",").ToList());
            Console.WriteLine($"{sportsPackingLabel[sportsPackingLabel.Count - 1][1]}: {sportsPackingLabel[sportsPackingLabel.Count - 1][0]}, Price each: ${sportsPackingLabel[sportsPackingLabel.Count - 1][2]:F2}, Quantity: {sportsPackingLabel[sportsPackingLabel.Count-1][3]}");
        }
        List<double> sportsOrderCost = sports.CalculateOrderCost();
        Console.WriteLine($"Shipping: ${sportsOrderCost[1]:F2}");
        Console.WriteLine($"Total Cost: ${(sportsOrderCost[0]+sportsOrderCost[1]):F2}");




    }
}

