using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fr1 = new Fraction();
        Console.WriteLine(fr1.GetTop());
        Console.WriteLine(fr1.GetBottom());
        Console.WriteLine(fr1.GetFractionString());
        Console.WriteLine(fr1.GetDecimalValue());

        Fraction fr2 = new Fraction(5);
        Console.WriteLine(fr2.GetTop());
        Console.WriteLine(fr2.GetBottom());
        Console.WriteLine(fr2.GetFractionString());
        Console.WriteLine(fr2.GetDecimalValue());

        Fraction fr3 = new Fraction(3,4);    
        Console.WriteLine(fr3.GetTop());
        Console.WriteLine(fr3.GetBottom());
        Console.WriteLine(fr3.GetFractionString());
        Console.WriteLine(fr3.GetDecimalValue());
    }
}