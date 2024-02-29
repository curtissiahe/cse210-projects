using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}, how are you today?");
        Console.WriteLine("Do you want to play the guessing game?");
        string reply = Console.ReadLine();

        if (reply == "Yes")
        {
            int guessing;
            do
            {
                Console.WriteLine("What is your magic number?");
                string answer = Console.ReadLine();
                guessing = int.Parse(answer);

                if (guessing > number)
                {
                    Console.WriteLine("Your magic number is higher than our magic number. Please try again!");
                }
                else if (guessing < number)
                {
                    Console.WriteLine("Your magic number is smaller than our magic number. Please try again!");
                }
                else
                {
                    Console.WriteLine("Bravo, you made it!");
                }
            } while (guessing != number);
        }
        else
        {
            Console.WriteLine("Okay, maybe another time!");
        }
    }
}
