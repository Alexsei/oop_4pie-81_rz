using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class StepTime
    {
        private List<Airport> listAirports;
        private List<Flight> listFlights;

        StepTime(List<Airport> listAirports, List<Flight> listFlights)
        {
            this.listAirports = listAirports;
            this.listFlights = listFlights;
        }
    }
}