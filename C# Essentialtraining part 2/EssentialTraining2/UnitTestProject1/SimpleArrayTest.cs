using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInitialization()
        {
            var SimpleArrayTest = new SimpleArray();
            var SimpleArrayLength = SimpleArrayTest.GroceryList.Length;
            Assert.AreEqual(4, SimpleArrayLength);
            Assert.AreEqual("Bread", SimpleArrayTest.GroceryList[1]);
        }

        [TestMethod]
        public void TestTostring()
        {
            var SimpleArrayTest = new SimpleArray();
            var testString = SimpleArrayTest.ToString();
            //var startString = testString.Substring(0, 25);
            //Assert.AreEqual("The grocery list contains", startString);

            Assert.IsTrue(testString.StartsWith("The grocery list contains "));
        }
    }
}
