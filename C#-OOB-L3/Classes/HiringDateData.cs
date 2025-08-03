﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOB_L3.Classes
{
    internal class HiringDateData
    {
        private int day;
        private int month;
        private int year;
        public HiringDateData(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }

    }
    /*
        2.Develop a Class to represent the Hiring Date Data:
          ● Consisting of fields to hold the day, month and Years.
 */
}
