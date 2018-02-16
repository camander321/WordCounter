using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void Constructor_StoreTextInput()
    {
      RepeatCounter counter = new RepeatCounter("some text");
      Assert.AreEqual("some text", counter.GetText());
    }
    
    [TestMethod]
    public void GetIsValid_ValidateInputString()
    {
      RepeatCounter counter;
      
      counter = new RepeatCounter("");
      Assert.AreEqual(false, counter.GetIsValid());
      
      counter = new RepeatCounter("some text");
      Assert.AreEqual(true, counter.GetIsValid());
    }
    
    [TestMethod]
    public void IsValidChar_CheckIfCharPartOfWord()
    {
      RepeatCounter counter = new RepeatCounter("");
      
      Assert.AreEqual(true, counter.IsValidChar('a', true));
      Assert.AreEqual(false, counter.IsValidChar('.', true));
      Assert.AreEqual(false, counter.IsValidChar('-', true));
      Assert.AreEqual(true, counter.IsValidChar('a', false));
      Assert.AreEqual(false, counter.IsValidChar('.', false));
      Assert.AreEqual(true, counter.IsValidChar('-', false));
    }
    
    [TestMethod]
    public void SplitWords_AddWordListToDictionary()
    {
      RepeatCounter counter = new RepeatCounter("This, is a string...it is a Long, long string.");
      
      Assert.AreEqual(2, counter.GetWordCounts()["long"]);
      Assert.AreEqual(2, counter.GetWordCounts()["string"]);
      Assert.AreEqual(1, counter.GetWordCounts()["this"]);
    }
    
    [TestMethod]
    public void SortWords_ReturnAListSortedByCount()
    {
      RepeatCounter counter = new RepeatCounter("This, is a string...it is a Long, long string.");
      
      Assert.AreEqual("is", counter.GetSortedWords()[0]);
      Assert.AreEqual("a", counter.GetSortedWords()[1]);
      Assert.AreEqual("string", counter.GetSortedWords()[2]);
      Assert.AreEqual("long", counter.GetSortedWords()[3]);
    }
    
    [TestMethod]
    public void GetCountForWord_GetCountForSpecificWord()
    {
      RepeatCounter counter = new RepeatCounter("This, is a string...it is a Long, long string.");
      
      Assert.AreEqual(2, counter.GetCountForWord("string"));
      Assert.AreEqual(1, counter.GetCountForWord("this"));
      Assert.AreEqual(0, counter.GetCountForWord("cat"));
    }
    
    
  }
}