using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory; //compile-time type is ICreditUnionFactory, but run-time type is SavingsAccountFactory
            var myCitiAcount = factory.GetSavingsAccount("CITI-1234"); //compile-time type is ISavingsAccount, but run-time type is CitiSavingsAccount
            var myNationalAccount = factory.GetSavingsAccount("NATIONAL-1234"); //compile-time type is ISavingsAccount, but run-time type is NationalSavingsAccount

            Console.WriteLine("My Citi account balance is " + myCitiAcount.Balance +
                            "\nMy National account balance is " + myNationalAccount.Balance);

            //Console.WriteLine("myCitiAcount run time type is " + myCitiAcount.GetType() +
            //                "\nmyNationalAccount run time type is " + myNationalAccount.GetType() +
            //                "\nfactory run time type is " + factory.GetType());

            Console.ReadLine();
        }
    }


    //Product
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    //Concrete product
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }

    //Another concrete prodict
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }

    //Creator or Factory
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    //Concrete creator
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
                return new CitiSavingsAccount();
            else if (acctNo.Contains("NATIONAL"))
                return new NationalSavingsAccount();
            else
                throw new ArgumentException("Unexpected account format.");
        }
    }

}
