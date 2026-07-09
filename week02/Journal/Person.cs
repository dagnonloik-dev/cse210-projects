using System;

public class Person
{
    public string _firstName;
    public string _lastName;
    public int _age;

    public void Display()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}, Age: {_age}");
    }
}

