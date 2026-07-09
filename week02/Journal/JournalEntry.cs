using System;

public class JournalEntry
{
    public string _prompt;
    public string _entry;
    public DateTime _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()} - Prompt: {_prompt}");
        Console.WriteLine($"{_entry}");
        Console.WriteLine();
    }

}