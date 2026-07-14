using System;
using System.Collections.Generic;
using System.IO;

// Exceeded required functionality by adding a search feature to the journal program.
//  The user can now search for specific keywords in their journal entries, and the program will display any matching entries. 
// If no matches are found, a message will be displayed indicating that no entries were found containing the keyword.

class Program
{
    static void Main(string[] args)
    {
        List<string> journalEntries = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What is your best scripture today?"
        };        

        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        string choice = "";
        while(choice != "5")
        {
            string menu = "Please select one of the following choices: \n" +
                      "1. Write\n" +
                      "2. Display\n" +
                      "3. Load\n" +
                      "4. Save\n" +
                      "5. Search\n" +
                      "6. Quit\n" +
                      "What would you like to do? ";

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next( 0,journalEntries.Count);
            
            Console.Write(menu);
            choice = Console.ReadLine();

            if (choice == "1")
            {
                JournalEntry entry = new JournalEntry();
                string randomPrompt = journalEntries[randomNumber];

                Console.WriteLine($"{randomPrompt}");
                Console.Write("> ");
                entry._entry = Console.ReadLine();
                entry._date = DateTime.Now;
                entry._prompt = randomPrompt;

                journal._entries.Add(entry);
            }
            else
            {
                if(choice == "2")
                {
                    journal.DisplayJournalEntries();
                }
                else if(choice == "3")
                {
                    Console.WriteLine("What is the filename? ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                }
                else if(choice == "4")
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                }
                else if(choice == "5")
                {
                    Console.Write("What is your keyword? ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                }
                else if(choice == "6")
                {
                    Console.WriteLine("Quitting the program...");
                }      
            }
                        
        }

    }    

}