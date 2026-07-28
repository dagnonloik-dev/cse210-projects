using System;
public class Comment
{
    private string _person;
    private string _text;

    public Comment(string author, string text)
    {
        _person = author;
        _text = text;
    }

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"{_person} --> {_text}");
    }
}