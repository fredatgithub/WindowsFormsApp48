﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void TestMethod2()
    {
      var result = ClassLibraryHelper.ClassHelper.GetHelloWorld();
      Assert.IsFalse(string.IsNullOrEmpty(result));
    }
  }
}
