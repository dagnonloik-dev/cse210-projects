using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void DisplayJournalEntries()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SearchEntries(string keyword)
    {
        bool found = false;

        foreach(JournalEntry entry in _entries)
        {
            if(entry._entry.ToLower().Contains(keyword.ToLower()) || entry._prompt.ToLower().Contains(keyword.ToLower())) 
            {
                entry.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine();
            Console.WriteLine($"No entries found containing the keyword: {keyword}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputWriter = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputWriter.WriteLine($"{entry._date.ToShortDateString()}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
       string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                JournalEntry entry = new JournalEntry();
                entry._date = DateTime.Parse(parts[0]);
                entry._prompt = parts[1];
                entry._entry = parts[2];
                _entries.Add(entry);
            }
        }    
    }

}
