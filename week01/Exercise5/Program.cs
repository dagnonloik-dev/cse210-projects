using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();

       string userName = PromptUserName();
       int userNumber = PromptUserNumber();
       int squareNumber = SquareNumber(userNumber);

       DisplayResult(userName, squareNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string userAnswer = Console.ReadLine();
        int userNumber = int.Parse(userAnswer); 
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}