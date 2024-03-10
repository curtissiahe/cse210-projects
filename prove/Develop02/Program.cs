using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    LoadJournalFromFile(journal);
                    break;
                case 4:
                    SaveJournalToFile(journal);
                    break;
                case 5:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Choose an entry option:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load the journal from a file");
        Console.WriteLine("4. Save the journal to a file");
        Console.WriteLine("5. Quit");
    }

    static int GetUserChoice()
    {
        Console.Write("Enter your choice (1-5): ");
        return int.Parse(Console.ReadLine());
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string randomPrompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine("Prompt: " + randomPrompt);
        Console.WriteLine("Write your journal entry:");
        string entryText = Console.ReadLine();

        journal.AddEntry(randomPrompt, entryText, DateTime.Now);
        Console.WriteLine("Entry added successfully.");
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter the file path to load the journal from: ");
        string filePath = Console.ReadLine();
        journal.LoadFromFile(filePath);
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter the file path to save the journal to: ");
        string filePath = Console.ReadLine();
        journal.SaveToFile(filePath);
    }
}
