using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PicoYPlaca.Model
{
    public class Validation
    {
        Date date;

        internal Date Date
        {
            get { return date; }
            set { date = value; }
        }

        Vehicle vehicle;

        internal Vehicle Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }

        Time time;

        internal Time Time
        {
            get { return time; }
            set { time = value; }
        }

        public bool isValid;
        public String error;

        //Constructor
        public Validation(Date date, Vehicle vehicle, Time time)
        {
            this.date = date;
            this.vehicle = vehicle;
            this.time = time;
        }

        public void canBeOnRoad() {

            bool plateIsValid = Vehicle.verifyPlate();
            int dateDay = Date.getDayOfTheWeekFromDate();

            error = "Go ahead all in order";

            bool isTheDay = Vehicle.getPicoPlacaDayOfPlate() == dateDay;
            bool isInPicoPlacaTime = Time.hasCorrectFormat() && Time.checkTimeInIntervals();

            if (plateIsValid && !isTheDay && isInPicoPlacaTime)
                isValid = true;
            else if (plateIsValid && isTheDay && !isInPicoPlacaTime) {
                isValid = true;
            }
            else if (plateIsValid && isTheDay && isInPicoPlacaTime)
            {
                isValid = false;
                error = "Pico y Placa in this moment, vehicle not allowed to be on road";
            }
            else if (!plateIsValid)
            {
                isValid = false;
                error = "Strange Plate better not run in Quito";
            }
        }
    }
}
