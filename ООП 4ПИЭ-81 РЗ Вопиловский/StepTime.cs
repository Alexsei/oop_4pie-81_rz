using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
  public class StepTime // класс управляющий шагом временного интервала
  {
    private int sTime = 0;
    private List<Airport> listAirports; // ссылка на список аэропортов
    private List<Flight> listFlights;// ссылка на список рейсов
    private List<Crash> listCrash;// ссылка на список крушений

    public StepTime(List<Airport> listAirports, List<Flight> listFlights, List<Crash> listCrash)  // инициализация
    {
      this.listAirports = listAirports;
      this.listFlights = listFlights;
      this.listCrash = listCrash;
    }

    public int STime { get { return this.sTime; } }  // текуший временной шаг

    public void step() // сделать временной шаг
    {
      for (int i=0; i< listAirports.Count; i++)
      {
        if (!(listAirports[i].putDown())) // запросить посадку самолета, если небыло посадки самолета
        {
          listAirports[i].startFlight(); // Запустить рейс
        }
      listAirports[i].service(); // провести сервис обслуживание 
      }
      for (int i = 0; i < listFlights.Count; i++)
      {
        if (!(listFlights[i].step())) // если полет неуспешен
        {
          listCrash.Add(new Crash(listFlights[i], this.sTime));
          listFlights.RemoveAt(i);
          i--;
        }
      }
      this.sTime++; // изменить время
    }
  }
}