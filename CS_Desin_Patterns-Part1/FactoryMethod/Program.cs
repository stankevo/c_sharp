using System;

namespace FactoryMethod
{
    public class Program
    {
       

    }

    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }

    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }

    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    public class SavingdsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
                return new CitiSavingsAccount();
            else if (acctNo.Contains("NATIONAL"))
                return new NationalSavingsAccount();
            else
                throw new ArgumentException("Invalid account number.");
        }
    }
    
}
