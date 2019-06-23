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
        protected int maxFuel;            // максимум топлива
        protected int fuelConsumption; // потребление топлива за 1 тик на кг веса
        protected int fuel;            // количество топлива на самолете: кг


        public Aircraft(string name, string model, int weight, int flightTime, int serviceTime, int speed, int maxFuel, int fuelConsumption, int fuel)
        {   // инициализация
            this.name = name;
            this.model = model;
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            this.maxFuel = maxFuel;
            this.fuelConsumption = fuelConsumption;
            this.fuel = fuel;
        }
        public Aircraft(Aircraft air, string name)
        {
            air.getAll(out string n, out string model, out int weight, out int flightTime, out int serviceTime,
                out int speed, out int maxFuel, out int fuelConsumption, out int fuel);
            this.name = name;
            this.model = model;
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            this.maxFuel = maxFuel;
            this.fuelConsumption = fuelConsumption;
            this.fuel = fuel;
        }

        public int RateFuel // текущий расход топлива за тик
        {
            get
            {
                int rate;
                rate = fuelConsumption * (weight + fuel) / weight;
                return rate;
            }
        }

        public int Fuel // остаток топлива
        {
            get  {
                return this.fuel;
            }
            set 
            {
                this.fuel = value;
            }
        }

        public int ServTime // время обслуживания
        {
            get            {
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

        public int FuelConsumption
        {
            get => default;

        }

        public void getAll(out string name, out string model, out int weight, out int flightTime, out int serviceTime,
            out int speed, out int maxFuel, out int fuelConsumption, out int fuel)
        {
            name = this.name;
            model = this.model;
            weight = this.weight;
            flightTime = this.flightTime;
            serviceTime = this.serviceTime;
            speed = this.speed;
            maxFuel = this.maxFuel;
            fuelConsumption = this.fuelConsumption;
            fuel = this.fuel;
        }
    }

    public class WarAircraft : Aircraft
    {
        private const string type = "wat"; // тип военный

        public WarAircraft(Aircraft air, string name) : base(air, name)
        {
        }
        public WarAircraft(string name, string model, int weight, int flightTime, int serviceTime,
             int speed, int maxFuel, int fuelConsumption, int fuel) : base(name, model, weight, flightTime, serviceTime,
             speed, maxFuel, fuelConsumption, fuel)
        {
        }
    }

    public class WalkingAircraft : Aircraft
    {
        private const string type = "walking"; // тип прогулочный

        public WalkingAircraft(Aircraft air, string name) : base(air, name)
        {
        }

        public WalkingAircraft(string name, string model, int weight, int flightTime, int serviceTime,
         int speed, int maxFuel, int fuelConsumption, int fuel) : base(name, model, weight, flightTime, serviceTime,
         speed, maxFuel, fuelConsumption, fuel)     {         }
    }

    public class CargoAircraft : Aircraft  
    {
        private const string type = "cargo"; // тип грузовой
        private int cargo = 0;
        private int maxCargo;

        public CargoAircraft(Aircraft air, string name, int maxCargo) : base(air, name)
        {
            this.maxCargo = maxCargo;
        }

         public CargoAircraft(string name, string model, int weight, int flightTime, int serviceTime,
         int speed, int maxFuel, int fuelConsumption, int fuel, int maxCargo) : base(name, model, weight, flightTime, serviceTime,
         speed, maxFuel, fuelConsumption, fuel)
            {
                this.maxCargo = maxCargo;
            }
            public new double GetRateFuel // текущий расход топлива за тик
        {
            get
            {
                double rate;
                rate = fuelConsumption  * (weight + fuel + cargo) / weight; 
                return rate;
            }
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
        }

        public PassengerAircraft(string name, string model, int weight, int flightTime, int serviceTime,
         int speed, int maxFuel, int fuelConsumption, int fuel, int maxPassenger) : base(name, model, weight, flightTime, serviceTime,
         speed, maxFuel, fuelConsumption, fuel )
            {
                this.maxPassenger = maxPassenger;
            }
        public new double GetRateFuel // текущий расход топлива за тик
        {
            get
            {
                double rate;
                rate = fuelConsumption*(weight + fuel + (passenger * 100)) / weight;
                return rate;
            }
        }
    }
}