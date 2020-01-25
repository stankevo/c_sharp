using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining2;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauseTest
    {
        [TestMethod]
        public void IsAwesomeSouceTest()
        {
            var testInstance = new AwesomeSaucse();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Traile r Trash");

            //expect true
            Assert.IsTrue(testInstance.IsAwesomeSouce("Trailer Trash"));

            //expect false
            Assert.IsFalse(testInstance.IsAwesomeSouce("Ketchup"));

        }
    }
}
