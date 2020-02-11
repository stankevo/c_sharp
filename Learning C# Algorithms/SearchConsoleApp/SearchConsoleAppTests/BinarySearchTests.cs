using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchConsoleApp;

namespace SearchConsoleAppTests
{
    [TestClass]
    public class BinarySearchTests
    {
        private int[] a = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        private int[] b = { 0, 1 };
        private int[] c = { 1, 2, 3 };
        private int[] d = { 3 };
        private int[] e = new int[3];

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, SearchUtilities.BinarySearch(a, 30));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, SearchUtilities.BinarySearch(b, 1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, SearchUtilities.BinarySearch(b, 0));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, SearchUtilities.BinarySearch(c, 2));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(-1, SearchUtilities.BinarySearch(c, 10));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(0, SearchUtilities.BinarySearch(d, 3));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(-1, SearchUtilities.BinarySearch(d, 0));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(-1, SearchUtilities.BinarySearch(e, 3));
        }
    }
}
