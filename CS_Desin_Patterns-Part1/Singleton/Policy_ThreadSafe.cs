using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Policy_ThreadSafe
    {
        // this code will work well, but it is too long
        //
        //private static readonly object _lock = new object();

        //private static Policy_ThreadSafe _instance;
        //public static Policy_ThreadSafe Instance
        //{
        //    get
        //    {
        //        lock (_lock)
        //        {
        //            if (_instance == null)
        //                _instance = new Policy_ThreadSafe();
        //            return _instance;
        //        }
        //    }
        //}

        //here is a shorter version
        private static readonly Policy_ThreadSafe _instance = new Policy_ThreadSafe();
        public static Policy_ThreadSafe Instance
        {
            get { return _instance; }
        }

        private Policy_ThreadSafe()
        {

        }

        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;


    }
}
