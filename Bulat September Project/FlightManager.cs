using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulat_September_Project
{
    public class FlightManager
    {
        public List<Flight> FlightSchedule { get; private set; } = new List<Flight>();

        public Flight GetFlight(int flightID)
        {
            if (FlightSchedule.Count == 0)
            {
                return null;
            }
            foreach (Flight f in FlightSchedule)
            {
                if (f.FlightID == flightID)
                {
                    return f;
                }
            }
            return null;
        }

        public void AddFlight(Flight f)
        {
            Flight t = GetFlight(f.FlightID);

            if (t == null)
            {
                FlightSchedule.Add(f);
            }
            else
            {
                throw new Exception("В базе уже существуют данные о полете с таким номером рейса");
            }
        }

        public void RemoveFlight(int flightID)
        {
            Flight f = GetFlight(flightID);
            if (f == null)
            {
                throw new Exception("Рейс с данным номером не найден");
            }
            FlightSchedule.Remove(f);
        }

        public void EditFlight(int flightID, Flight that)
        {
            Flight f = GetFlight(flightID);
            if (f == null)
            {
                throw new Exception("Рейс с данным номером не найден");
            }
            int i = FlightSchedule.IndexOf(f);
            FlightSchedule[i] = that;
        }
    }
}
