using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public virtual void Run() 
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");

        Thread.Sleep(2000); // Pause for 2 seconds

        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity.");
        Console.WriteLine($"Total duration: {_duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }
}
