using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _text;
    private bool _isValid = true;
    private Dictionary<string, int> _wordCounts = new Dictionary<string, int>();
    private List<string> _sortedWords = new List<string>();
    
    public RepeatCounter(string text)
    {
      _text = text.ToLower();
      _isValid = _text.Length > 0;
      SplitWords();
      SortWords();
    }
    
    public string GetText()
    {
      return _text;
    }
    
    public bool GetIsValid()
    {
      return _isValid;
    }
    
    public Dictionary<string, int> GetWordCounts()
    {
      return _wordCounts;
    }
    
    public List<string> GetSortedWords()
    {
      return _sortedWords;
    }
    
    public int GetCountForWord(string word)
    {
      word = word.ToLower();
      if (!_wordCounts.ContainsKey(word))
        return 0;
      return _wordCounts[word];
    }
    
    public void SortWords()
    {
      foreach(string word in _wordCounts.Keys)
      {
        int i = 0;
        while (i < _sortedWords.Count && _wordCounts[word] <= _wordCounts[_sortedWords[i]])
          i++;
        
        _sortedWords.Insert(i, word);
      }
    }
    
    public bool IsValidChar(char c, bool startOfWord)
    {
      if(c >= 'a' && c <= 'z')
        return true;
      else if (!startOfWord && (c == '\'' || c == '-' || c == '_'))
        return true;
      else 
        return false;
    }
    
    public void SplitWords()
    {
      int wordStart = 0;
      int wordEnd = 0;
      while (wordStart < _text.Length)
      {
        if (IsValidChar(_text[wordStart], true))
        {
          wordEnd = wordStart + 1;
          while (wordEnd < _text.Length && IsValidChar(_text[wordEnd], false))
          {
            wordEnd++;
          }
          
          string word = _text.Substring(wordStart, wordEnd - wordStart);
          if(_wordCounts.ContainsKey(word))
              _wordCounts[word]++;
          else
            _wordCounts.Add(word, 1);

          wordStart = wordEnd;
        }
        wordStart++;
      }
    }
  }
}