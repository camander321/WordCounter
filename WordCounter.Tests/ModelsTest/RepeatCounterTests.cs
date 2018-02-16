using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void Test_JustATest_True()
    {
      Assert.AreEqual(true, Words.Test(true));
      Assert.AreEqual(false, Words.Test(false));
    }
  }
}