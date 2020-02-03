using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Weather
{
    public class WeatherData
    {
        public static IEnumerable<WeatherObservation> ReadRange(
            TextReader text,
            DateTime? start = null,
            DateTime? end = null,
            Action<string> errorHandler = null)
        {
            var data = ReadAll(text, errorHandler);

            var range = data.Where(item => (item.TimeStamp >= (start != null ? start : DateTime.MinValue)
                                     && item.TimeStamp <= (end != null ? end : DateTime.MaxValue)));
            return range;
        }
          
        public static IEnumerable<WeatherObservation> ReadAll(TextReader text, Action<string> errorHandler = null)
        {
            string line = text.ReadLine();
            while (line != null)
            {
                var lineParsed = WeatherObservation.TryParse(line, out WeatherObservation wo);
                if (lineParsed)
                {
                    yield return wo;
                }
                else
                {
                    try
                    {
                        errorHandler?.Invoke("Could not parse the line " + line);
                    }
                    catch { }
                } 
                line = text.ReadLine();
            }
        }
    }
}
