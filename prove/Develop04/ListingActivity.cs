using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        // Add more prompts as needed
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 90; // Default duration: 90 seconds
    }

    public override void Run()
    {
        base.Run();

        Console.WriteLine("Starting listing activity...");
        
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("You have 5 seconds to start listing...");

        Thread.Sleep(5000); // Pause for 5 seconds

        Console.WriteLine("Time's up!");

        // Simulate user listing items (not implemented in this basic example)
        // You can add user input here to actually list items

        Console.WriteLine("Displaying the number of items listed...");
        Thread.Sleep(2000); // Pause for 2 seconds

        DisplayEndingMessage();
    }
}
