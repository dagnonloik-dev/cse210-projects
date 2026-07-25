using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// For creativity my program work with a library of scriptures rather than a single one
// and the scripture is randomly choose for the user 

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Joshua", 1, 9), "Be strong and courageous. Do not be afraid; do not be discouraged, for the Lord your God will be with you wherever you go."),
            new Scripture(new Reference("Isaiah", 41, 10), "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."),
            new Scripture(new Reference("Matthew", 5, 16), "Let your light shine before others, that they may see your good deeds and glorify your Father in heaven."),
            new Scripture(new Reference("Matthew", 11, 28), "Come to me, all you who are weary and burdened, and I will give you rest."),
            new Scripture(new Reference("1 Corinthians", 10, 13), "No temptation has overtaken you except what is common to mankind. And God is faithful; he will not let you be tempted beyond what you can bear."),
            new Scripture(new Reference("James", 1, 5), "If any of you lacks wisdom, you should ask God, who gives generously to all without finding fault, and it will be given to you."),
            new Scripture(new Reference("2 Timothy", 1, 7), "For God has not given us a spirit of fear, but of power and of love and of a sound mind."),
            new Scripture(new Reference("Hebrews", 11, 1), "Now faith is confidence in what we hope for and assurance about what we do not see."),
            new Scripture(new Reference("Galatians", 5, 22, 23), "But the fruit of the Spirit is love, joy, peace, forbearance, kindness, goodness, faithfulness, gentleness and self-control."),
            new Scripture(new Reference("1 Peter", 5, 7), "Cast all your anxiety on him because he cares for you."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I lack nothing."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.")
        };

        Scripture scripture = scriptures[new Random().Next(scriptures.Count)];
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine("Press Enter to hide a word, or type 'quit' to finish.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }


            Console.Clear();
            scripture.HideRandomWords();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to finish.");
        }
    }
}