using System;

class Entry
{
    public string Prompt { get; }
    public string EntryText { get; }
    public DateTime Date { get; }

    public Entry(string prompt, string entryText, DateTime date)
    {
        Prompt = prompt;
        EntryText = entryText;
        Date = date;
    }
}
