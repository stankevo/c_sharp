using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace Singleton_Tests
{
    [TestClass]
    public class UnitTest1
    {
        // this is not a part of Singleton pattern, just testing multithreading
        public delegate Policy_ThreadSafe GetInstance_del();
        GetInstance_del getThreadSafeInstance = GetPolicyThreadSafeInstance;

        public delegate Policy GetInstance_del2();
        GetInstance_del2 getInstance = GetPolicyInstance;

        public static Policy_ThreadSafe GetPolicyThreadSafeInstance()
        {
            return Policy_ThreadSafe.Instance;
        }

        public static Policy GetPolicyInstance()
        {
            return Policy.Instance;
        }
        //


        [TestMethod]
        public void IsPolicyASingleton()
        {
            Assert.AreSame(Policy.Instance, Policy.Instance);
            //Assert.AreSame(Policy.Instance, new Policy());
        }

        [TestMethod]
        public void IsPolicyASingletonAndThreadSafe()
        {
            IAsyncResult res = getThreadSafeInstance.BeginInvoke(null, null);
            var instance1 = Policy_ThreadSafe.Instance;
            var instance2 = getThreadSafeInstance.EndInvoke(res);
            Assert.AreSame(instance1, instance2);
        }

        // this test fails time-to time because the Policy class is not thread-safe
        [TestMethod]
        public void IsPolicyASingletonAndThreadSafe2()
        {
            IAsyncResult res = getInstance.BeginInvoke(null, null);
            var instance1 = Policy.Instance;
            var instance2 = getInstance.EndInvoke(res);
            Assert.AreSame(instance1, instance2);
        }
    }
}
