using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactusCodeChallenge.Subroutines
{
    class FiveSecondsOfWork
    {
        public FiveSecondsOfWork() { }

        public int ConvertTimeToSeconds(int minutes, int hours)
        {
            var minutesToSeconds = ConvertMinutesToSeconds(minutes);
            var hoursToSeconds = ConvertHoursToSeconds(hours);

            var result = minutesToSeconds + hoursToSeconds;

            if (result % 5 != 0)
            {
                result = 5 * (int)Math.Round(result / 5.0);
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
