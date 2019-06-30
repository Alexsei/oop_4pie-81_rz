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
        private int busyDocks = 0; // количество занятых доков
        private string name;      // наименование аэропорта
        private Docks[] airDocks; // массив доков для самолетов
        private int type;      // тип аэропорта: 1 - гражданский, 0 - военный
        private int sendPassengers; // количество отправленных пассажиров
        private int getPassengers; // количество прилетевших пассажиров
        private int sendCargo; // количество отправленного груза
        private int getCargo; // количество полученного груза

        private Random rnd = new Random();
        private List<Flight> listFlights;
        private List<Airport> listAirports;

        public Airport(string name , int maxDocks, int x, int y, int type, List<Flight> listFlights, List<Airport> listAirports)
        {
            this.name = name;
            this.maxDocks = maxDocks;
            this.x = x;
            this.y = y;
            this.type = type;
            this.airDocks = new Docks[maxDocks];
            for (int i=0; i < this.maxDocks; i++)
            {
                this.airDocks[i] = new Docks();
            }
            this.listFlights = listFlights;
            this.listAirports = listAirports;

        }

        public int X
        {
            get{
                return this.x;
            }
        }

        public int Y
        {
            get            {
                return this.y;
            }
        }

        public string Name  // наименование
        {
            get            {
                return this.name;
            }
        }

        public int MaxDocks  // максимум доков
        {
            get
            {
                return this.maxDocks;
            }
        }

        public int Type  // тип аэропорта
        {
            get
            {
                return this.type;
            }
        }

        public Docks getAirDocks(int id)
        {
            return airDocks[id];
        }

        public int FreeDocks // количество свободных доков
        {
            get
            {
                int free = 0;
                for (int i = 0; i < airDocks.Length; i++)
                {
                    if (airDocks[i].Status == 0) { free++; }
                }
                    return free;
            }
        } 

        public bool addAirInDock(Aircraft air) // поместить самолет в док
        {
            if (this.FreeDocks != 0)
            {
                for (int i = 0; i < airDocks.Length; i++)
                {
                    if (airDocks[i]== null) { airDocks[i] = new Docks(); };
                    if (airDocks[i].Status == 0)  // если док свободен
                    {
                        airDocks[i].Status = 1;
                        airDocks[i].ServiceTime = air.ServTime;
                        airDocks[i].Air = air;
                        return true;
                    }
                }
                return false;
            } else { return false; }
        }

        public void startFlight()  // взлет самолета
        {
            List<int> IdAirDock = new List<int>(); // Ид доков
            for (int i = 0; i < airDocks.Length; i++)
            {
                switch (airDocks[i].Status)
                {
                    case 2:     // если самолет готов
                        IdAirDock.Add(i);
                        break;
                    case 1:     // если самолет на сервисе 
                        airDocks[i].ServiceTime--;
                        if (airDocks[i].ServiceTime <= 0)// если время сервиса закончилось, 
                        {
                            airDocks[i].Status = 2;     //статус готов
                        } 
                        break;
                }

            }
            if ((IdAirDock.Count > 0)&& //если есть самолеты в доке
                    (rnd.Next(25) > listFlights.Count) ) //  чем больше текуших рейсов тем меньше новых вылето
            {
                int IdAir = IdAirDock[rnd.Next(IdAirDock.Count)];  // выбор случайного Ид дока

                airDocks[IdAir].Air.Loading();
              //  Console.WriteLine(airDocks[IdAir].Air.Cargo);

                this.sendPassengers = this.sendPassengers + airDocks[IdAir].Air.Passenger;
                this.sendCargo = this.sendCargo + airDocks[IdAir].Air.Cargo;
                List<int> id = new List<int>();
                for (int i = 0; i < listAirports.Count; i++)
                {
                    if (listAirports[i].name == this.name) continue; // если это текуший аэропорт пропустить
                    if ((airDocks[IdAir].Air.Priority != 0)&&(listAirports[i].Type == 0) ) continue; // для не военных самолетов пропустить военный аэропорт
                    id.Add(i);  // добавить ид аэропорта в массив
                }
                listFlights.Add(new Flight(listAirports[id[rnd.Next(id.Count)]],      // id[rnd.Next(id.Count)] выбор случайного аэропорта
                    this, airDocks[IdAir].Air)); // запуск рейса 
                airDocks[IdAir].Status = 0;
                airDocks[IdAir].Air = null;
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
                    int newPriority = (10 - Convert.ToInt32(listFlights[IdFlights[j]].FlightTime)) + listFlights[IdFlights[j]].Board.Priority;
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

        public int SendPassengers { get { return this.sendPassengers; } } // отправленно пассажиров
        public int GetPassengers { get { return this.getPassengers; } }// прибыло пассажиров
        public int SendCargo { get { return this.sendCargo; } }// отправленно груза
        public int GetCargo { get { return this.getCargo; } }// прибыло груза


    }

    public class Docks
    {
        private int status;      // 0- свободен  ; 1- обслуживание  ;  2 - готовый
        private int serviceTime; // осталось времени на обслуживание
        private Aircraft air;  // самолет

        public Docks()
        {
            this.status = 0;
        }

        public int Status
        {
            get  {
                return this.status;
            }
            set  {
                this.status = value;
            }
        }
        public int ServiceTime
        {
            get
            {
                return this.serviceTime;
            }
            set
            {
                this.serviceTime = value;
            }
        }
        public Aircraft Air
        {
            get
            {
                return this.air;
            }
            set
            {
                this.air = value;
            }
        }
    }
}
