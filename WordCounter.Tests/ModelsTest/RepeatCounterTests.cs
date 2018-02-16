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
  }
}