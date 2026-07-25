using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                displayText += new string ('_', word.GetDisplayText().Length) + " ";
            }
            else
            {
                displayText += word.GetDisplayText() + " ";
            }
        }

        return displayText.Trim();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int index;

        do
        {
            index = random.Next(_words.Count);
        } while (_words[index].IsHidden());

        _words[index].Hide();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}