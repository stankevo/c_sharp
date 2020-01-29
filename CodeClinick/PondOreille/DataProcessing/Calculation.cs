using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessing
{
    public class Calculation
    {
        public static double SlopeCoefficient(DataRecord record1, DataRecord record2)
        {

            var timeDiff = record1.RecordDateTime - record2.RecordDateTime;
            double res = (record1.BarometricPressure - record2.BarometricPressure) / timeDiff.TotalSeconds;
            return res;
        }
           
    }
}
 