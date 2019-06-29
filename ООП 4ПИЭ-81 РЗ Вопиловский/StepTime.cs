using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class StepTime
    {
        private int sTime = 0;
        private List<Airport> listAirports;
        private List<Flight> listFlights;
        private List<Crash> listCrash;

        public StepTime(List<Airport> listAirports, List<Flight> listFlights, List<Crash> listCrash)
        {
            this.listAirports = listAirports;
            this.listFlights = listFlights;
            this.listCrash = listCrash;
        }

        public int STime { get { return this.sTime; } }  // 

        public void step()
        {
            for (int i=0; i< listAirports.Count; i++)
            {
             //   Console.WriteLine(listAirports[i].Name + ": Запрос на посадку");
                if (!(listAirports[i].putDown())) // запросить посадку самолета, если небыло посадки самолета
                {
             //       Console.WriteLine(listAirports[i].Name + ": Нет самолетов на посадке. Запрос на вылет");
                    listAirports[i].startFlight(); // Запустить рейс
                }

            }
            Console.WriteLine("текуших рейсов: "+ listFlights.Count);
            for (int i = 0; i < listFlights.Count; i++)
            {
                
                if (!(listFlights[i].step())) // если полет неуспешен
                {
                  //  Console.WriteLine("рейс: " + listFlights[i].Board.Name + " терпит крушение");
                    listCrash.Add(new Crash(listFlights[i], this.sTime));
                    listFlights.RemoveAt(i);
                    i--;

                }
            }
            this.sTime++; 
        }
    }
}