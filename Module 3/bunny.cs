using System;
using System.Collections.Generic;

class Bunny
{
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;
}

class Program
{
    static void Main()
    {
        Bunny bunny1 = new Bunny();
        bunny1.Name = "Barnaby";
        bunny1.LikesCarrots = true;
        bunny1.LikesHumans = true;

        Bunny bunny2 = new Bunny();
        bunny2.Name = "Fluffy";
        bunny2.LikesCarrots = true;
        bunny2.LikesHumans = false;

        List<Bunny> bunnies = new List<Bunny>();

        bunnies.Add(bunny1);
        bunnies.Add(bunny2);

        foreach (Bunny bunny in bunnies)
        {
            Console.WriteLine("Bunny Name: " + bunny.Name);
            Console.WriteLine("Likes Carrots: " + bunny.LikesCarrots);
            Console.WriteLine("Likes Humans: " + bunny.LikesHumans);
            Console.WriteLine();
        }
    }
}
