using System;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Creating instances of activities
        MindfulnessActivity breathingActivity = new BreathingActivity(60); // 60 seconds
        MindfulnessActivity reflectionActivity = new ReflectionActivity(60); // 60 seconds
        MindfulnessActivity listingActivity = new ListingActivity(60); // 60 seconds

        // Running activities
        breathingActivity.Start();
        reflectionActivity.Start();
        listingActivity.Start();
    }
}
