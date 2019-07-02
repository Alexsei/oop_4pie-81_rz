using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
  public class Airport
  {
    private int x;           // координата  X
    private int y;           // координата  Y
    private int maxDocks;      // Места стоянки самолетов
    private string name;      // наименование аэропорта
    private Docks[] boardDocks; // массив доков для самолетов
    private int type;      // тип аэропорта: 1 - гражданский, 0 - военный
    private int sendPassengers; // количество отправленных пассажиров
    private int getPassengers; // количество прилетевших пассажиров
    private int sendCargo; // количество отправленного груза
    private int getCargo; // количество полученного груза
    private Random rnd = new Random();  // генератор случайных чисел
    private List<Flight> listFlights;    // ссылка на список рейсов
    private List<Airport> listAirports;  // ссылка на список аэропортов

    public Airport(string name , int maxDocks, int x, int y, int type, List<Flight> listFlights, List<Airport> listAirports) // инициализация
    {
      this.name = name;           
      this.maxDocks = maxDocks;   
      this.x = x;           
      this.y = y;
      this.type = type;
      this.boardDocks = new Docks[maxDocks];
      for (int i=0; i < this.maxDocks; i++)  // инициализация массива доков
      {  this.boardDocks[i] = new Docks();  }
      this.listFlights = listFlights;
      this.listAirports = listAirports;
    }

    // свойства *****************************
    public int X {get {return this.x;} } // координата X
    public int Y {get {return this.y;} } // координата X
    public string Name {get {return this.name;} } // наименование
    public int MaxDocks {get {return this.maxDocks;} }// максимум доков
    public int Type {get {return this.type;} }// тип аэропорта
    public int FreeDocks // количество свободных доков
    {
        get
        {
            int free = 0;
            for (int i = 0; i < boardDocks.Length; i++)
            {
                if (boardDocks[i].Status == 0) { free++; }
            }
                return free;
        }
    }
    public int SendPassengers { get { return this.sendPassengers; } } // отправленно пассажиров
    public int GetPassengers { get { return this.getPassengers; } }// прибыло пассажиров
    public int SendCargo { get { return this.sendCargo; } }// отправленно груза
    public int GetCargo { get { return this.getCargo; } }// прибыло груза


    //  методы -------------------------------
    public Docks getAirDocks(int id){return boardDocks[id]; } // ссылка на док по ид
    public bool addAirInDock(Aircraft air) // поместить самолет в док
    {
        if (this.FreeDocks != 0)
        {
            for (int i = 0; i < boardDocks.Length; i++)
            {
                if (boardDocks[i]== null) { boardDocks[i] = new Docks(); };
                if (boardDocks[i].Status == 0)  // если док свободен
                {
                    boardDocks[i].Status = 1;
                    boardDocks[i].ServiceTime = air.ServTime;
                    boardDocks[i].Board = air;
                    return true;
                }
            }
            return false;
        } else { return false; }
    }

    public void service() // метод сервесного обслуживания
    {
      for (int i = 0; i < boardDocks.Length; i++)
      {
        if ((boardDocks[i].ServiceTime > 0)) // если есть время на сервис  и статус =1
        {
          boardDocks[i].ServiceTime--;  // уменьшить время обслуживания
        } else if (boardDocks[i].Status == 1) // если сервис <= 0 и статус = 1 
        {
          boardDocks[i].Status = 2;  // изменить статус
        }
      }
    }
    public void startFlight()  // взлет самолета
    {
      List<int> IdAirDock = new List<int>(); // Ид доков
      for (int i = 0; i < boardDocks.Length; i++)
      {
        if (boardDocks[i].Status == 2) // если статус = 2
        {
          IdAirDock.Add(i);   // добавить в массив запуска
        }
      }
      if ((IdAirDock.Count > 0)&& //если есть самолеты в доке
         (rnd.Next(25) > listFlights.Count) ) //  чем больше текуших рейсов тем меньше новых вылето
      {
        int IdAir = IdAirDock[rnd.Next(IdAirDock.Count)];  // выбор случайного Ид дока
        boardDocks[IdAir].Board.Loading();
        this.sendPassengers = this.sendPassengers + boardDocks[IdAir].Board.Passenger; // статистика вылета пассажиров
        this.sendCargo = this.sendCargo + boardDocks[IdAir].Board.Cargo;  //  статистика грузов
        List<int> id = new List<int>();
        for (int i = 0; i < listAirports.Count; i++)
        {
          if (listAirports[i].name == this.name) continue; // если это текуший аэропорт пропустить
          if ((boardDocks[IdAir].Board.Type != 0)&&(listAirports[i].Type == 0) ) continue; // для не военных самолетов пропустить военный аэропорт
          id.Add(i);  // добавить ид аэропорта в массив
        }
        listFlights.Add(new Flight(listAirports[id[rnd.Next(id.Count)]],      // id[rnd.Next(id.Count)] выбор случайного аэропорта
          this, boardDocks[IdAir].Board)); // запуск рейса 
        boardDocks[IdAir].Status = 0;
        boardDocks[IdAir].Board = null;
      }
    }
    public bool putDown()   //посадка самолетов
    {
      List<int> IdFlights = new List<int>();
      for (int i = 0; i < listFlights.Count; i++) //  поиск самолетов на посадку
      {
        if ((listFlights[i].X==this.x)&&(listFlights[i].Y == this.y))  // если самолет у аэропорта
        {
          IdFlights.Add(i); // добавить в очередь на посадку
        }
      }
      if ((IdFlights.Count>0)&& (this.FreeDocks > 1))  // если есть самолеты на посадку и свободный док
      {
        int id = 0, priority = 0; // Ид рейса и приоритет на посадку
        for (int j= 0; j < IdFlights.Count; j++)  // Поиск рейса с максимальным приоритетом 
        {
          int newPriority = (10 - Convert.ToInt32(listFlights[IdFlights[j]].FlightTime))*10 + listFlights[IdFlights[j]].Board.Type;
          if (newPriority > priority) {  // если приоритет текушего самолета выше поставить на посадку
            priority = newPriority;
            id = IdFlights[j];
          };
        }
        this.getPassengers = this.getPassengers + listFlights[id].Board.Passenger;
        this.getCargo = this.getCargo + listFlights[id].Board.Cargo;    
        this.addAirInDock(listFlights[id].Board);  // поместить самолет в док
        listFlights.RemoveAt(id);  // рейс
        return true; // результат посадки +
      } else
      {
        return false; // результат посадки -
      }
            


    }
  }

  public class Docks  // док для самолетов вспомогательный класс Airport
  {
    private int status;      // 0- свободен  ; 1- обслуживание  ;  2 - готовый
    private int serviceTime; // осталось времени на обслуживание
    private Aircraft board;  // самолет
    public Docks() // инициализация
    {     this.status = 0;    }
    // свойства *****************************
    public int Status {get {return this.status;} set { this.status = value;}}// статус дока
    public int ServiceTime    {get{return this.serviceTime;}set{this.serviceTime = value;}} // время обслуживания
    public Aircraft Board {get {return this.board;} set {this.board = value;}} // самолет
  }
}
