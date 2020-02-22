using LoggerClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMonitoringEngine
{
    class Program
    {
        private static System.Timers.Timer _timer;
        private static Logger log = new Logger(Properties.Settings.Default.MonitorServiceDBConnectionString);

        static void Main(string[] args)
        {
            _timer = new System.Timers.Timer(10000); // 10000 - is the interval 10 seconds
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;

            //try
            //{
            //    var x = 0;
            //    var y = 10;
            //    var z = y / x;
            //}
            //catch (Exception ex)
            //{
            //    
            //    log.RecordException(ex);
            //}

            Console.WriteLine("The monitor is running...");
            Console.ReadLine();
        }

        private static void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            // get the values and insert to DB
            try
            {
                int cpuVlue = GetCpuValue();
                int memoryValue = GetMemoryValue();
                DateTime dt = DateTime.Now;

                DataSet1TableAdapters.DataCollectedTableAdapter adapter = new DataSet1TableAdapters.DataCollectedTableAdapter();
                adapter.InsertNewRecord(cpuVlue, memoryValue, dt);
            }
            catch (Exception ex)
            {
                log.RecordException(ex);
            }
        }
         
        private static int GetCpuValue()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnValue = (int)cpuCounter.NextValue();
            return returnValue;
        }

        private static int GetMemoryValue()
        {
            var cpuCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            int returnValue = (int)cpuCounter.NextValue();
            return returnValue;
        }
    }
}
