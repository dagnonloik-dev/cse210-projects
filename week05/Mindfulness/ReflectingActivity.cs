using System;
using System.Collections.Generic;
public class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description): base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you did something really difficult",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "How did you feel when it was complete?",
            "Did you learn something useful about this experience?",
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage(); 
        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Clear();
        
        DisplayQuestions();
        
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
       
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");

        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetActivityDuration());
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");
            ShowSpinner(7);
            Console.WriteLine();
        }
    }
}
    