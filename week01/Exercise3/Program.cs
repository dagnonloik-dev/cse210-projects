using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while(response == "yes")
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,101);
            
            Console.WriteLine($"What is the magic number? {randomNumber}");
            int number = -1;
            int counter = 0;

            while(number != randomNumber)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                number = int.Parse(answer);
                counter++;

                if(number > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if(number < randomNumber)
                {
                    Console.WriteLine("Higher");
                }

            }
                    
            Console.WriteLine($"You guessed it in {counter} testing.");
            Console.Write("Do you want to play again? (yes/no) ");
            response = Console.ReadLine();
        }
        
        
    }
}