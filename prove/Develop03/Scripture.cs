// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<int> _hiddenIndices;
    private int _currentIndex;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        InitializeWords(text);
        InitializeHiddenIndices();
    }

    private void InitializeWords(string text)
    {
        string[] wordsArray = text.Split(' ');
        _words = wordsArray.Select(word => new Word(word)).ToList();
    }

    private void InitializeHiddenIndices()
    {
        _hiddenIndices = Enumerable.Range(0, _words.Count).ToList();
        ShuffleHiddenIndices();
        _currentIndex = 0;
    }

    private void ShuffleHiddenIndices()
    {
        Random random = new Random();
        int n = _hiddenIndices.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            int value = _hiddenIndices[k];
            _hiddenIndices[k] = _hiddenIndices[n];
            _hiddenIndices[n] = value;
        }
    }

    public void HideRandomWord()
    {
        if (_currentIndex < _words.Count)
        {
            int indexToHide = _hiddenIndices[_currentIndex];
            _words[indexToHide].Hide();
            _currentIndex++;
        }
    }

    public void RevealNextHiddenWord()
    {
        if (_currentIndex > 0)
        {
            _currentIndex--;
            int indexToShow = _hiddenIndices[_currentIndex];
            _words[indexToShow].Show();
        }
    }

    public string GetReferenceDisplayText()
    {
        return _reference.GetDisplayText();
    }

    public string GetOriginalText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public string GetCurrentText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _currentIndex >= _words.Count;
    }
}
