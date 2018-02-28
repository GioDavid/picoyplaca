using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoYPlaca.Model
{
    public class Date
    {
        //Values asigned to the days of the week, this is going to help to verify the day of PICO Y PLACA
        private enum WeekDays : int { MONDAY = 1, TUESDAY = 2, WEDNESDAY = 3, THURSDAY = 4, FRIDAY = 5, SATURDAY = 6, SUNDAY = 7 };

        DateTime value;
        int dayOfTheWeek;

        public int DayOfTheWeek
        {
            get { return dayOfTheWeek; }
            set { dayOfTheWeek = value; }
        }

        internal DateTime Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        //Constructor
        public Date(DateTime date)
        {
            this.value = date;
        }

        public int getDayOfTheWeekFromDate()
        {
            int day = (int)this.value.DayOfWeek;
            return day;
        }
    }
}
