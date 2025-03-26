using System;

public class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse || _endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }

        else
        { 
        return $"{_book} {_chapter}:{_verse}-{_endVerse})";
        }
    }

}