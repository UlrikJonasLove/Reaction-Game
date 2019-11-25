using System;
using System.Threading;

class ReactionGame
{
    static void Main()
    {
        Console.WriteLine("Ok, get ready...");
        Thread.Sleep(2000);
        Console.WriteLine("NOW! (press enter after input)");

        int tickCount = Environment.TickCount;
        string input = Console.ReadLine();
        int seconds = Environment.TickCount - tickCount;

        Console.WriteLine();
        Console.WriteLine("Din reaktionstid blev: " + seconds + " milisekunder.");
        Console.ReadLine();
    }
}