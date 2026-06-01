using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();
        int userNumber = 1;
        int sum = 0;
        double averageNumber = 0;
        int largestNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
        while(userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        }

        foreach(int number in numbers)
        {
            sum = sum + number;

            if(largestNumber <= number)
            {
                largestNumber = number;
            }
        }
        averageNumber = Math.Round( (double)sum / numbers.Count , 3 );
        numbers.Sort();

        foreach (int number in numbers)
        {
            if(number > 0)
            {
                positiveNumbers.Add(number);
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {averageNumber}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {positiveNumbers[0]}");
        Console.WriteLine("The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}