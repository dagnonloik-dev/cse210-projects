using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment assignment2 = new MathAssignment("Samuel Bennett", "Fractions", "7.3", "8-19");
        WritingAssignment assignment3 = new WritingAssignment("Samuel Bennett", "Composition", "My Family");
        
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}