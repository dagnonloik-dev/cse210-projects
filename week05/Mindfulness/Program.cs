using System;

/* Creativity: I added a mindfulness activity log that automatically saves each completed activity to a text file. The log records the activity name, date, time, and duration selected by the user.This allows the user to keep a history of their mindfulness sessions. */

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while(choice != "4")
        {
            Console.Clear();
            string menu = "Menu Options:\n" +
                        "  1. Start breathing activity\n" +
                        "  2. Start reflecting activity\n" +
                        "  3. Start listing activity\n" +
                        "  4. Quit\n";
            Console.Write(menu);
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Run();
                Console.Clear();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflecting.Run();
                Console.Clear();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.Run();
                Console.Clear();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Console.Clear();
            }
        }
    }   
}