using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DataProcessing
{
    public class DataRecord
    {
        public string DateString {get; set;}
        public string TimeString { get; set; }
        public float BarometricPressure { get; set; }
        public DateTime RecordDateTime { get; set; }

        public DataRecord(string newDateString, string newTimeString, float newBarometricPressure)
        {
            DateString = newDateString;
            TimeString = newTimeString;
            BarometricPressure = newBarometricPressure;

            string dateTimeString = DateString.Replace('_', '-') + " " + TimeString;
            RecordDateTime = DateTime.Parse(dateTimeString);
        }

    }
}
