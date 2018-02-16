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
      Assert.AreEqual(true, RepeatCounter.IsValidChar('a', true));
      Assert.AreEqual(false, RepeatCounter.IsValidChar('.', true));
      Assert.AreEqual(false, RepeatCounter.IsValidChar('-', true));
      Assert.AreEqual(true, RepeatCounter.IsValidChar('a', false));
      Assert.AreEqual(false, RepeatCounter.IsValidChar('.', false));
      Assert.AreEqual(true, RepeatCounter.IsValidChar('-', false));
    }
    
    [TestMethod]
    public void SplitWords_GetListOfWordsInString()
    {
      Assert.AreEqual("this", RepeatCounter.SplitWords("this isn't, a long-string!!!")[0]);
      Assert.AreEqual("isn't", RepeatCounter.SplitWords("this isn't, a long-string!!!")[1]);
      Assert.AreEqual("a", RepeatCounter.SplitWords("this isn't, a long-string!!!")[2]);
      Assert.AreEqual("long-string", RepeatCounter.SplitWords("this isn't, a long-string!!!")[3]);
      Assert.AreEqual(4, RepeatCounter.SplitWords("this isn't, a long-string!!!").Count);
    }
  }
}