using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProcessing;

namespace PondOreilleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter record 1:");
            Console.WriteLine("Enter date in format YYYY_MM_DD:");
            string date1 = Console.ReadLine();
            Console.WriteLine("Enter time in format hh:mm:ss:");
            string time1 = Console.ReadLine();
            Console.WriteLine("Enter barometric pressure:");
            string pressure1 = Console.ReadLine();

            Console.WriteLine("Enter record 2:");
            Console.WriteLine("Enter date in format YYYY_MM_DD:");
            string date2 = Console.ReadLine();
            Console.WriteLine("Enter time in format hh:mm:ss:");
            string time2 = Console.ReadLine();
            Console.WriteLine("Enter barometric pressure:");
            string pressure2 = Console.ReadLine();

            var record1 = new DataRecord(date1, time1, float.Parse(pressure1));
            var record2 = new DataRecord(date2, time2, float.Parse(pressure2));

            double result = Calculation.SlopeCoefficient(record1, record2);

            Console.WriteLine("The slope coefficient is " + result.ToString());
            Console.WriteLine("Press any key to close.");
            Console.ReadLine();
        }
    }
}
