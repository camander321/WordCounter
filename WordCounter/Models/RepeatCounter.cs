using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _text;
    private bool _isValid = true;
    private Dictionary<string, int> _wordCounts = new Dictionary<string, int>();
    
    public RepeatCounter(string text)
    {
      _text = text.ToLower();
      _isValid = _text.Length > 0;
      CountWords();
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
    
    public void CountWords()
    {
      List<string> words = SplitWords(_text);
      foreach(string word in words)
      {
        if(_wordCounts.ContainsKey(word))
          _wordCounts[word]++;
        else
          _wordCounts.Add(word, 1);
      }
    }
    
    public static bool IsValidChar(char c, bool startOfWord)
    {
      if(c >= 'a' && c <= 'z')
        return true;
      else if (!startOfWord && (c == '\'' || c == '-' || c == '_'))
        return true;
      else 
        return false;
    }
    
    public static List<string> SplitWords(string text)
    {
      List<string> words = new List<string>();
      int wordStart = 0;
      int wordEnd = 0;
      while (wordStart < text.Length)
      {
        if (IsValidChar(text[wordStart], true))
        {
          wordEnd = wordStart + 1;
          while (wordEnd < text.Length && IsValidChar(text[wordEnd], false))
          {
            wordEnd++;
          }
          
          words.Add(text.Substring(wordStart, wordEnd - wordStart));
          wordStart = wordEnd;
        }
        wordStart++;
      }
      
      return words;
    }
  }
}