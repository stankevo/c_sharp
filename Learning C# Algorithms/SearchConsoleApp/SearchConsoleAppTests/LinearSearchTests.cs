using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchConsoleApp;

namespace SearchConsoleAppTests
{
    [TestClass]
    public class LinearSearchTests
    {
        private int[] a = { 10, 4, 7, 90, 574 };
        private int[] b = { 1 };
        private int[] c = new int[1];

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, SearchUtilities.LinearSearch(a, 574));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-1, SearchUtilities.LinearSearch(a, 3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, SearchUtilities.LinearSearch(b, 1));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(-1, SearchUtilities.LinearSearch(b, 2));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(-1, SearchUtilities.LinearSearch(c, 2));
        }
    }
}
