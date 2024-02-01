using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExactusCodeChallenge.Subroutines
{
    public class FiveSecondsOfWork
    {

        private Regex _rgHours = new Regex("\\d+?(?=h)");
        private Regex _rgMinutes = new Regex("\\d+?(?=m)");

        public FiveSecondsOfWork() { }

        public int ConvertTimeToSeconds(string time)
        {

            string minutes = _rgMinutes.Match(time).ToString();
            string hours = _rgHours.Match(time).ToString();

            var result = 0;
            if (String.IsNullOrEmpty(minutes))
            {
                result = (ConvertHoursToSeconds(Int32.Parse(hours))) / 5;

            }
            else if (String.IsNullOrEmpty(hours))
            {
                result = (ConvertMinutesToSeconds(Int32.Parse(minutes))) / 5;

            }
            else
            {

                var minutesToSeconds = ConvertMinutesToSeconds(Int32.Parse(minutes));
                var hoursToSeconds = ConvertHoursToSeconds(Int32.Parse(hours));
                result = (minutesToSeconds + hoursToSeconds) / 5;

            }

            return result;
        }

        private int ConvertMinutesToSeconds(int minutes)
        {
            return minutes*60;
        }

        private int ConvertHoursToSeconds(int hours)
        {
            return hours*3600;
        }
    }
}
