using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> accounts = new List<string>()
            {
                "CITI-1234",
                "NATIONAL-5678",
                "UNKNOWN-333"
            };

            foreach (string accountNo in accounts)
            {
                ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountNo);
                if (abstractFactory is null)
                    Console.WriteLine("Credit union account number '{0}' is not valid.", accountNo);
                else
                {
                    ISavingsAccount savingsAcct = abstractFactory.CreateSavingsAccount();
                    ILoanAccount loanAcct = abstractFactory.CreateLoanAccount();
                }
            }

            Console.ReadLine();

        }
    }
}
