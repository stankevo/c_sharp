using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;


namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<string> Words;

        static void Main(string[] args)
        {
            logger.Trace("The program started.");
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
                logger.Error("Error: " + ex.Message);
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(@"Could not find the file C:temp\test\textfile.txt");
                logger.Error("Error: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unknown error occured: " + ex.Message);
                logger.Error("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This is the finally{} block which executes no matter what.");
            }
        }
    }  
}
