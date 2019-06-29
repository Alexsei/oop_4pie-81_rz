using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public  class Aircraft
    {
        protected string name;            // Наименование 
        protected string model;           // модель
        protected int weight;          // вес самолета: кг
        protected int flightTime;         // максимальное время полета: тик времени
        protected int serviceTime;        // время обслуживание в аэропарту:  тик времени
        protected int speed;              // рассотояние за один тик времени
        protected int priority;
        protected Random rnd = new Random();

        public Aircraft(string name, string model, int weight, int flightTime, int serviceTime, int speed, int priority)
        {   // инициализация
            this.name = name;
            this.model = model;
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            this.priority = priority;
            //      this.maxFuel = maxFuel;
            //      this.fuelConsumption = fuelConsumption;
            //      this.fuel = fuel;
        }
        public Aircraft(Aircraft air, string name)
        {
            air.getAll(out string n, out string model, out int weight, out int flightTime, out int serviceTime,
                out int speed, out int priority);
            this.name = name;
            this.model = model;
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            this.priority = priority;

        }


        public int ServTime // время обслуживания
        {
            get {
                return this.serviceTime;
            }
        }

        public string Name // наименование
        {
            get
            {
                return this.name;
            }
        }

        public string Model // модель
        {
            get
            {
                return this.model;
            }
        }

        public int FlightTime  // максимальное время полета
        {
            get
            {
                return this.flightTime;
            }
        }

        public int Speed  // Скорость самолета
        {
            get
            {
                return this.speed;
            }
        }  // 
        public int Priority { get { return this.priority; } }  // индекс приоритета при посадке

        public int FuelConsumption
        {
            get => default;

        }

        public int Weight { get { return this.weight; } }  // вес самолета

        public virtual int Cargo { get { return 0; } set {  } }  // возврашает вес нагрузки;

        public void getAll(out string name, out string model, out int weight, out int flightTime, out int serviceTime,
            out int speed, out int priority)
        {
            name = this.name;
            model = this.model;
            weight = this.weight;
            flightTime = this.flightTime;
            serviceTime = this.serviceTime;
            speed = this.speed;
            priority = this.priority;
            //         maxFuel = this.maxFuel;
            //         fuelConsumption = this.fuelConsumption;
            //         fuel = this.fuel;
        }
        public virtual void Loading() {  } //предстартовая загрузка

        public virtual int Passenger { get { return 0; } set { } }// количество пассажирова
        public virtual int MaxPassenger { get { return 0; } }
        public virtual int MaxCargo { get { return 0; } }

    }

    public class WarAircraft : Aircraft
    {
        public WarAircraft(Aircraft air, string name) : base(air, name)
        {       }
        public WarAircraft(string name, string model, int weight, int flightTime, int serviceTime,
                int speed) : base(name, model, weight, flightTime, serviceTime, speed, 0)
        {  }
        public override void Loading() {  } 

    }

    public class WalkingAircraft : Aircraft
    {
        public WalkingAircraft(Aircraft air, string name) : base(air, name)
        {        }

        public WalkingAircraft(string name, string model, int weight, int flightTime, int serviceTime,
            int speed) : base(name, model, weight, flightTime, serviceTime, speed, 1) {  }
        public override void Loading() { }
    }

    public class CargoAircraft : Aircraft
    {
        private int cargo = 0;
        private int maxCargo;

        public CargoAircraft(CargoAircraft air, string name) : base(air, name)
        {
            this.maxCargo = air.maxCargo;

        }

        public CargoAircraft(string name, string model, int weight, int flightTime, int serviceTime,
        int speed, int maxCargo) : base(name, model, weight, flightTime, serviceTime, speed, 2)
        {
            this.maxCargo = maxCargo;
        }
        public override int Cargo { get { return this.cargo; } set { this.cargo = value; } } // возврашает вес нагрузки;

        public override int MaxCargo { get { return this.maxCargo; } } // возврашает вес нагрузки;
       
        public override void Loading()          //предстартовая загрузка
        {
            this.cargo = this.rnd.Next(this.maxCargo); ;
            Console.WriteLine("Загрузка самолета: " + this.cargo + "кг / " + this.maxCargo + "кг");
        }
    }

    public class PassengerAircraft : Aircraft
    {
        private int passenger = 0;
        private int maxPassenger;


        public PassengerAircraft(PassengerAircraft air, string name ) : base(air, name)
        {
            this.maxPassenger = air.maxPassenger;
        }

        public PassengerAircraft(string name, string model, int weight, int flightTime, int serviceTime,
            int speed, int maxPassenger) : base(name, model, weight, flightTime, serviceTime,
            speed, 3)
        {
            this.maxPassenger = maxPassenger;
        }
        public override int Cargo { get { return this.passenger * 100; } }  // возврашает вес нагрузки;
        public override int Passenger { get { return this.passenger; } set { this.passenger = value; } }

        public override int MaxPassenger { get { return this.maxPassenger; } }

        public override void Loading()  //предстартовая загрузка
        {
            this.passenger = rnd.Next(maxPassenger);
            Console.WriteLine("Пассажиров принято на борт: " + this.passenger + " / "+ this.maxPassenger);
        }

    }
    
}