using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;

        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Scheese");

            CrazyMathProblem();

            ReadTestFile();
            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = (income / i);
            }
            return income;
        }

        private static void ReadTestFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:temp\test\textfile.txt"))
                {
                    string text = sr.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            //catch
            //{
            //    Console.WriteLine(@"Could not find the file C:temp\test\textfile.txt");
            //}
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine(@"Could not find the directory C:temp\test\");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(@"Could not find the file C:temp\test\textfile.txt");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unknown error occured: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This is the finally{} block which executes no matter what.");
            }
        }
    }  
}
