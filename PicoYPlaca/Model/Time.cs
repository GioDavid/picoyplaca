using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace PicoYPlaca.Model
{
    public class Time
    {

        //MORNING INTERVAL
        private DateTime startFirstIntervalHour =  DateTime.ParseExact("07:00:00", "HH:mm:ss",
                                        CultureInfo.InvariantCulture);
        private DateTime endFirstIntervalHour = DateTime.ParseExact("09:30:00", "HH:mm:ss",
                                        CultureInfo.InvariantCulture);

        //AFTERNOON INTERVAL
        private DateTime startSecondIntervalHour = DateTime.ParseExact("16:00:00", "HH:mm:ss",
                                        CultureInfo.InvariantCulture);
        private DateTime endSecondIntervalHour = DateTime.ParseExact("19:30:00", "HH:mm:ss",
                                        CultureInfo.InvariantCulture);

        //PATTERN OF THE TIME
        private static String timePattern = "^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$";

        String value;
        DateTime currentTime;

        public DateTime CurrentTime
        {
            get { return currentTime; }
            set { currentTime = value; }
        }

        public String Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        //Constructor
        public Time(String value)
        {
            this.value = value;
        }

        //checks if the hour format is correct
        public bool hasCorrectFormat() 
        {
            bool isCorrect = System.Text.RegularExpressions.Regex.IsMatch(this.value, timePattern);
            return isCorrect;
        }

        //checks if the time in between an interval
        public bool checkTimeInIntervals (){
            DateTime time = DateTime.ParseExact(this.value, "HH:mm:ss",
                                        CultureInfo.InvariantCulture);

            if (time.TimeOfDay == startFirstIntervalHour.TimeOfDay) return true;
            if (time.TimeOfDay == endFirstIntervalHour.TimeOfDay) return true;

            if (time.TimeOfDay == startSecondIntervalHour.TimeOfDay) return true;
            if (time.TimeOfDay == endSecondIntervalHour.TimeOfDay) return true;

            if (time.TimeOfDay <= endFirstIntervalHour.TimeOfDay)
                return (time.TimeOfDay >= startFirstIntervalHour.TimeOfDay && time.TimeOfDay <= endFirstIntervalHour.TimeOfDay);
            else
                return (time.TimeOfDay >= startSecondIntervalHour.TimeOfDay && time.TimeOfDay <= endSecondIntervalHour.TimeOfDay);
        }
    }
}
