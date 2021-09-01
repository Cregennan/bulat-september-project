using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulat_September_Project
{
    public class Flight
    {
        public String ArrivalPoint { get; set; }

        public int FlightID { get; set; }
        
        public String AircraftType { get; set; }

        public Flight(String arrivalPoint, int flightID, String aircraftType)
        {
            this.AircraftType = aircraftType;
            this.ArrivalPoint = arrivalPoint;
            this.FlightID = flightID;
        }
    }
}
