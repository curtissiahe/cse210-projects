using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        bool continueHiding = true;
        while (continueHiding)
        {
            Console.Write("\nEnter the number of words to hide (or type 'quit' to exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                if (int.TryParse(input, out int numberOfWords))
                {
                    scripture.HideRandomWords(numberOfWords);

                    // Clear the console before displaying the modified scripture
                    Console.Clear();

                    Console.WriteLine("Scripture after hiding random words:");
                    Console.WriteLine(scripture.GetDisplayText());

                    // Ask the user if they want to continue hiding words
                    Console.Write("\nDo you want to continue hiding words? (yes/no): ");
                    string response = Console.ReadLine();
                    if (response.ToLower() != "yes")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'quit'.");
                }
            }
        }

        Console.WriteLine("\nProgram ended. Press any key to exit.");
        Console.ReadKey();
    }
}
