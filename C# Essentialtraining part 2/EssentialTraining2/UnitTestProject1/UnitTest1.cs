using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test1 = new Class1();
            var actualResult = test1.AddTwoDigits(9, 5);
            Assert.AreEqual(14, actualResult, "Epected 9 + 5 to be 14.");
        }
    }
}
