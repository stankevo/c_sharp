using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributesAndReflection_1
{
    class TestAttribute : Attribute { }
    class TestMethodAttribute : Attribute { }

    [Test]
    class MyTestSuite
    {
        public void HelperMethod()
        {
            // That helps your tests gt their job done...
            Console.WriteLine("This method will never be invoked because it does not have a TestMethodAttribute on it.");
        }

        [TestMethod]
        public void MyTest1()
        {
            Console.WriteLine("Doing some testing... ");
        }

        [TestMethod]
        public void MyTest2()
        {
            Console.WriteLine("Doing some other testing...");
        }

    }

    class Program
    { 
        static void Main(string[] args)
        {
            // find all test suites in this assembly (classes which are marked by TestAttribute)
            var testSuites =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetCustomAttributes(false).Any(a => a is TestAttribute)
                select t;

            // for each test suite:
            foreach (Type t in testSuites)
            {
                Console.WriteLine("Running tests in suite " + t.Name);
                // find all those methods which are test methods (methds which are marked by TestMethodAttribute)
                var testMethods =
                    from m in t.GetMethods()
                    where m.GetCustomAttributes(false).Any(a => a is TestMethodAttribute)
                    select m;

                // instantiate the test suite class
                object testSuiteInstance = Activator.CreateInstance(t);

                // start all test methods from this test suite
                foreach (MethodInfo mInfo in testMethods)
                    mInfo.Invoke(testSuiteInstance, new object[0]);
            }
                

            Console.ReadLine();
        }
    }
}
