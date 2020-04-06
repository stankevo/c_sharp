using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            double myResult = -1;
            try
            {
                myResult = Calculate(x); //x can be any number or 0 for example
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }
            Console.WriteLine(myResult);
            while (true)  // stack overflow exception
                myResult = Calculate(x);  // stack overflow exception
            Console.ReadKey();

            SAFEHANDLE
        }

        static double Calculate(int x)
        {
            try
            {
                x = x / 2;
                Calculate(x); // stack overflow exception
                throw new Exception("My Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
               // throw new Exception("Exception from the Catch block");
            }
            finally
            {
                x = 10;
            }
            return x;
        }
    }
}
