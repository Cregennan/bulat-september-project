using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulat_September_Project
{
    class FlightManager
    {
        public List<Flight> FlightSchedule { get; private set; }

        public Flight GetFlight(int flightID)
        {
            foreach (Flight f in FlightSchedule)
            {
                if (f.FlightID == flightID)
                {
                    return f;
                }
            }
            throw new Exception("В базе нет данных о полете с таким номером рейса");
        }
        public int GetFlightListID(int flightID)
        {
            for (int i = 0; i < FlightSchedule.Count; i++)
            {
                if (FlightSchedule[i].FlightID == flightID)
                {
                    return i;
                }
            }
            throw new Exception("В базе нет данных о полете с таким номером рейса");
        }
        public void AddFlight(Flight f)
        {
            Flight t = GetFlight(f.FlightID);
            if (t == null)
            {
                FlightSchedule.Append<Flight>(f);
            }
            else
            {
                throw new Exception("В базе уже существуют данные о полете с таким номером рейса");
            }
        }

        public void RemoveFlight(int flightID)
        {
            Flight f = GetFlight(flightID);
            FlightSchedule.Remove(f);
        }
    }
}
