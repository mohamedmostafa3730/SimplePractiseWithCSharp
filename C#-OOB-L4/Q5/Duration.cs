using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L4.Q5
{
    internal class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            ConvertSecondsToDuration(totalSeconds);
        }

        public override string? ToString()
        {
            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                return "Duration is zero";
            }else if (hours == 0 && minutes > 0)
            {
                return $"Minutes: {minutes}, Seconds: {seconds}";
            }
            else
            {
                return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
            }
        }

        private void ConvertSecondsToDuration(int totalSeconds)
        {
            hours = totalSeconds / 3600; // Extract hours from total seconds
            totalSeconds %= 3600;       // Remaining seconds after extracting hours
            minutes = totalSeconds / 60; // Extract minutes from remaining seconds
            seconds = totalSeconds % 60; // Remaining seconds after extracting minutes
        }



    }
}
