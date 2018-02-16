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
  }
}