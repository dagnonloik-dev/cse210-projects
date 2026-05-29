using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        string letter = "";
        string sign = "";
        
        // Determine the sign
        if(gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if(gradePercentage % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Determine letter grade based on percentage
        if(gradePercentage >= 90)
        {
            if(sign == "+")
            {
                sign = "";
            }
            letter = "A";
        }
        else if(gradePercentage >= 80)
        {
            letter = "B";
        }
        else if(gradePercentage >= 70)
        {
            letter = "C";
        }
        else if(gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            sign = "";
            letter = "F";
        }

        Console.WriteLine($"{letter}{sign}");                                                           

        if(gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }

    }
}