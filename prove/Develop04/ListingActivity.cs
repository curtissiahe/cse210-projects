using System;
using System.Threading;

// Listing activity
public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(int durationInSeconds) : base(durationInSeconds) { }

    public override void Start()
    {
        Console.WriteLine("\nListing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Duration: " + durationInSeconds + " seconds.");
        Thread.Sleep(5000); // Pause for preparation

        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("You have " + durationInSeconds + " seconds to list as many items as you can...");

        // Simulating listing items
        // You can modify this part as needed
        int itemCount = 0;
        while (durationInSeconds > 0)
        {
            // Simulating user input (in real program, this would be replaced by actual user input)
            Thread.Sleep(1000);
            durationInSeconds--;
            itemCount++;
        }

        Console.WriteLine("\nNumber of items listed: " + itemCount);

        EndActivity("Listing Activity");
    }
}
