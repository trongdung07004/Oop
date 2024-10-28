using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Date
    {
        private int month;

        private int day;

        private int year;

        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
        public int Year { get => year; set => year = value; }

        public Date(int theMonth, int theDay, int theYear)
        {
            if (theMonth > 0 && theMonth <= 12)
                this.month = theMonth;
            else
                this.month = 1;

            this.day = CheckDay(theDay);
            this.year = theYear;
        }

        public string DateToString()
        {
            return this.day.ToString() + "\\" + this.month.ToString() + "\\" + this.year.ToString();
        }

        public int CheckDay(int testDay)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (testDay > 0 && testDay <= daysPerMonth[this.month])
                return testDay;

            if (this.month == 2 && testDay == 29 && (this.year % 400 == 0 || (this.year % 4 == 0 && this.year % 100 != 0)))
                return testDay;

            return 1;
        }
    }
}
