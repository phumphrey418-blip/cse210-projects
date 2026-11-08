using System;

public class Word
{
    // Private attributes encapsulating the word's state
    private string _text;
    private bool _isHidden;

    // Constructor to initialize a word as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word (optional, but good practice)
    public void Show()
    {
        _isHidden = false;
    }

    // Getter to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns either the original word or underscores matching its length
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
