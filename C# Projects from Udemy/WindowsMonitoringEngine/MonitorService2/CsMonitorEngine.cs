using LoggerClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MonitorService2
{
    public partial class CsMonitorEngine : ServiceBase
    {
        private static System.Timers.Timer _timer;
        private static Logger log = new Logger(Properties.Settings.Default.MonitorServiceDBConnectionString);

        public CsMonitorEngine()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _timer = new System.Timers.Timer(10000); // 10000 - is the interval 10 seconds
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private static void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            // get the values and insert to DB
            try
            {
                int cpuVlue = GetCpuValue();
                int memoryValue = GetMemoryValue();
                DateTime dt = DateTime.Now;

                DataSet2TableAdapters.DataCollectedTableAdapter adapter = new DataSet2TableAdapters.DataCollectedTableAdapter();
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

        protected override void OnStop()
        {
        }
    }
}
