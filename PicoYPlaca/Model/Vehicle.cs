using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoYPlaca.Model
{
    public class Vehicle
    {
        //Values asigned to the days of the week, this is going to help to verify the day of PICO Y PLACA
        private enum WeekDays : int { MONDAY = 1, TUESDAY = 2, WEDNESDAY = 3, THURSDAY = 4, FRIDAY = 5, SATURDAY = 6, SUNDAY = 7 };
        private static String plateStartPattern = "^([A-Za-z]+)";
        private static String plateEndPattern = "([0-9]+)$";

        String plate;
        int picoPlacaDay;
        Boolean validPlate;

        public Boolean ValidPlate
        {
            get { return validPlate; }
            set { validPlate = value; }
        }

        public int PicoPlacaDay
        {
            get { return picoPlacaDay; }
            set { picoPlacaDay = value; }
        }

        public String Plate
        {
            get { return plate; }
            set { plate = value; }
        }

        //Constructor
        public Vehicle(string plate)
        {
            this.plate = plate;
        }

        public Boolean verifyPlate()
        {
            bool startPattern = System.Text.RegularExpressions.Regex.IsMatch(this.plate, plateStartPattern);
            bool endPattern = System.Text.RegularExpressions.Regex.IsMatch(this.plate, plateEndPattern);

            validPlate = startPattern & endPattern;

            return validPlate;
        }

        public String getPlate()
        {
            return this.plate;
        }

        public int getPicoPlacaDayOfPlate(){

            int last = (int)Char.GetNumericValue(this.plate.Last());

            switch (last)
            {
                case 1:
                    this.picoPlacaDay = (int) WeekDays.MONDAY;
                    break;
                case 2:
                    this.picoPlacaDay = (int) WeekDays.MONDAY;
                    break;
                case 3:
                    this.picoPlacaDay = (int)WeekDays.TUESDAY;
                    break;
                case 4:
                    this.picoPlacaDay = (int)WeekDays.TUESDAY;
                    break;
                case 5:
                    this.picoPlacaDay = (int)WeekDays.WEDNESDAY;
                    break;
                case 6:
                    this.picoPlacaDay = (int)WeekDays.WEDNESDAY;
                    break;
                case 7:
                    this.picoPlacaDay = (int)WeekDays.THURSDAY;
                    break;
                case 8:
                    this.picoPlacaDay = (int)WeekDays.THURSDAY;
                    break;
                case 9:
                    this.picoPlacaDay = (int)WeekDays.FRIDAY;
                    break;
                case 0:
                    this.picoPlacaDay = (int)WeekDays.FRIDAY;
                    break;

                default:
                    this.picoPlacaDay = 0;
                    break;
            }

            return this.picoPlacaDay;
        }

    }
}
