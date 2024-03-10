using System;
using System.Collections.Generic;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string entryText, DateTime date)
    {
        entries.Add(new Entry(prompt, entryText, date));
    }

    public void Display()
    {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Entry: {entry.EntryText}");
        }
    }

     public void SaveToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.EntryText}");
                }
            }
            Console.WriteLine("Journal entries saved to file: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving journal entries: " + ex.Message);
        }
    }

    public void LoadFromFile(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        DateTime date;
                        if (DateTime.TryParse(parts[0], out date))
                        {
                            string prompt = parts[1];
                            string entryText = parts[2];
                            entries.Add(new Entry(prompt, entryText, date));
                        }
                    }
                }
            }
            Console.WriteLine("Journal entries loaded from file: " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal entries: " + ex.Message);
        }

    }
}
