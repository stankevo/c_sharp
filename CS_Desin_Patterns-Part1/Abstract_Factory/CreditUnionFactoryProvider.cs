using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI"))
                return new CitiCreditUnionFactory();
            else if (accountNo.Contains("NATIONAL"))
                return new NationalCreditUnionFactory();
            else
                return null;
        }
    }
}
