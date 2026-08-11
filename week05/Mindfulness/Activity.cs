using System;
using System.IO;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public string GetActivityName()
    {
        return _name;
    }
    public string GetActivityDescription()
    {
        return _description;
    }

    public int GetActivityDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        SaveActivityLog();
        ShowSpinner(4);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            for (int i = 4; i >= 0 && DateTime.Now < endTime; i--)
            {
                if(i == 0 || DateTime.Now == endTime)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("\b \b");
                    Console.Write("Breathe in... ");
                    Thread.Sleep(1000);
                }else
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write($"Breathe in...{i}");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine();

            for (int i = 6; i >= 0 && DateTime.Now < endTime; i--)
            {
                if(i == 0 || DateTime.Now == endTime)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write("\b \b");
                    Console.Write($"Now breathe out... ");
                    Thread.Sleep(1000);
                }else
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write($"Now breathe out...{i}");
                    Thread.Sleep(1000);
                }
                
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public void SaveActivityLog()
    {
        string fileName = "mindfulness_log.txt";

        string log = 
            $"Activity: {_name}\n" +
            $"Date: {DateTime.Now.ToShortDateString()}\n" +
            $"Time: {DateTime.Now.ToLongTimeString()}\n" +
            $"Duration: {_duration} seconds\n" +
            "-----------------------------\n";

        File.AppendAllText(fileName, log);
    }
}