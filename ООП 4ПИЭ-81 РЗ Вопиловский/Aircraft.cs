using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class Aircraft
    {
        protected string name;            // Наименование 
        protected string model;           // модель
        protected int weight;          // вес самолета: кг
        protected int flightTime;         // максимальное время полета: тик времени
        protected int serviceTime;        // время обслуживание в аэропарту:  тик времени
        protected int speed;              // рассотояние за один тик времени
                                          //   protected int maxFuel;            // максимум топлива
                                          //   protected int fuelConsumption; // потребление топлива за 1 тик на кг веса
                                          //    protected int fuel;            // количество топлива на самолете: кг
        protected int priority = 0;
        private Random rnd = new Random();

        public Aircraft(string name, string model, int weight, int flightTime, int serviceTime, int speed)
        {   // инициализация
            this.name = name;
            this.model = model;
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            //      this.maxFuel = maxFuel;
            //      this.fuelConsumption = fuelConsumption;
            //      this.fuel = fuel;
        }
        public Aircraft(Aircraft air, string name)
        {
            air.getAll(out string n, out string model, out int weight, out int flightTime, out int serviceTime,
                out int speed);
            this.name = name;
            this.model = model;
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            //          this.maxFuel = maxFuel;
            //         this.fuelConsumption = fuelConsumption;
            //          this.fuel = fuel;
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

        public int Weight { get { return this.priority; } }  // вес самолета

        public int Cargo { get { return 0; } }  // возврашает вес нагрузки;

        public void getAll(out string name, out string model, out int weight, out int flightTime, out int serviceTime,
            out int speed)
        {
            name = this.name;
            model = this.model;
            weight = this.weight;
            flightTime = this.flightTime;
            serviceTime = this.serviceTime;
            speed = this.speed;
            //         maxFuel = this.maxFuel;
            //         fuelConsumption = this.fuelConsumption;
            //         fuel = this.fuel;
        }
        public void loading() { } //предстартовая загрузка

        public int Passenger { get { return 0; } }// количество пассажирова

    }

    public class WarAircraft : Aircraft
    {
        private const string type = "wat"; // тип военный
        public WarAircraft(Aircraft air, string name) : base(air, name)
        {
            this.priority = 0;
        }
        public WarAircraft(string name, string model, int weight, int flightTime, int serviceTime,
                int speed) : base(name, model, weight, flightTime, serviceTime,
                speed)
        { this.priority = 0; }

    }

    public class WalkingAircraft : Aircraft
    {
        private const string type = "walking"; // тип прогулочный


        public WalkingAircraft(Aircraft air, string name) : base(air, name)
        {
            this.priority = 1;
        }

        public WalkingAircraft(string name, string model, int weight, int flightTime, int serviceTime,
            int speed) : base(name, model, weight, flightTime, serviceTime,
            speed) { this.priority = 1; }
    }

    public class CargoAircraft : Aircraft
    {
        private const string type = "cargo"; // тип грузовой
        private int cargo = 0;
        private int maxCargo;

        public CargoAircraft(Aircraft air, string name, int maxCargo) : base(air, name)
        {
            this.maxCargo = maxCargo;
            this.priority = 2;
        }

        public CargoAircraft(string name, string model, int weight, int flightTime, int serviceTime,
        int speed, int maxCargo) : base(name, model, weight, flightTime, serviceTime,
        speed)
        {
            this.maxCargo = maxCargo;
            this.priority = 2;
        }
        public new int Cargo { get { return this.cargo; } set { this.cargo = value; } } // возврашает вес нагрузки;
        public new void loading()//предстартовая загрузка
        {
            Random rnd = new Random();
            this.cargo = rnd.Next(maxCargo);
        }
    }

    public class PassengerAircraft : Aircraft
    {
        private const string type = "passenger"; // тип пассажирский
        private int passenger = 0;
        private int maxPassenger;


        public PassengerAircraft(Aircraft air, string name, int maxPassenger) : base(air, name)
        {
            this.maxPassenger = maxPassenger;
            this.priority = 3;
        }

        public PassengerAircraft(string name, string model, int weight, int flightTime, int serviceTime,
            int speed, int maxPassenger) : base(name, model, weight, flightTime, serviceTime,
            speed)
        {
            this.maxPassenger = maxPassenger;
            this.priority = 3;
        }
        public new int Cargo { get { return this.passenger * 100; } }  // возврашает вес нагрузки;
        public new int Passenger { get { return this.passenger; } set { this.passenger = value; } }

        public new void loading()//предстартовая загрузка
        {
            Random rnd = new Random();
            this.passenger = rnd.Next(passenger);
        }

    }
    
}