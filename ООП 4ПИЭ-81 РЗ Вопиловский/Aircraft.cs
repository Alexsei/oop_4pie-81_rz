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
        protected double weight;          // вес самолета: кг
        protected int flightTime;         // максимальное время полета: тик времени
        protected int serviceTime;        // время обслуживание в аэропарту:  тик времени
        protected int speed;              // рассотояние за один тик времени
        protected int maxFuel;            // максимум топлива
        protected double fuelConsumption; // потребление топлива за 1 тик на кг веса
        protected double fuel;            // количество топлива на самолете: кг


        public Aircraft(string name, string model, double weight, int flightTime, int serviceTime, int speed, int maxFuel, double fuelConsumption, double fuel)
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
            air.getAll(out string n, out string model, out double weight, out int flightTime, out int serviceTime,
                out int speed, out int maxFuel, out double fuelConsumption, out double fuel);
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

        public double GetRateFuel // текущий расход топлива за тик
        {
            get {
                double rate;
                rate = (weight + fuel) * fuelConsumption;
                return rate;
            }
        }

        public void getAll(out string name, out string model, out double weight, out int flightTime, out int serviceTime,
            out int speed, out int maxFuel, out double fuelConsumption, out double fuel)
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
        public WarAircraft(string name, string model, double weight, int flightTime, int serviceTime,
             int speed, int maxFuel, double fuelConsumption, double fuel) : base(name, model, weight, flightTime, serviceTime,
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

        public WalkingAircraft(string name, string model, double weight, int flightTime, int serviceTime,
         int speed, int maxFuel, double fuelConsumption, double fuel) : base(name, model, weight, flightTime, serviceTime,
         speed, maxFuel, fuelConsumption, fuel)     {         }
    }

    public class CargoAircraft : Aircraft  
    {
        private const string type = "cargo"; // тип грузовой
        private double cargo = 0;
        private double maxCargo;

        public CargoAircraft(Aircraft air, string name, double maxCargo) : base(air, name)
        {
            this.maxCargo = maxCargo;
        }

         public CargoAircraft(string name, string model, double weight, int flightTime, int serviceTime,
         int speed, int maxFuel, double fuelConsumption, double fuel, double maxCargo) : base(name, model, weight, flightTime, serviceTime,
         speed, maxFuel, fuelConsumption, fuel)
            {
                this.maxCargo = maxCargo;
            }
            public new double GetRateFuel // текущий расход топлива за тик
        {
            get
            {
                double rate;
                rate = (weight + fuel+ cargo) * fuelConsumption;
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

        public PassengerAircraft(string name, string model, double weight, int flightTime, int serviceTime,
         int speed, int maxFuel, double fuelConsumption, double fuel, int maxPassenger) : base(name, model, weight, flightTime, serviceTime,
         speed, maxFuel, fuelConsumption, fuel )
            {
                this.maxPassenger = maxPassenger;
            }
        public new double GetRateFuel // текущий расход топлива за тик
        {
            get
            {
                double rate;
                rate = (weight + fuel + passenger * 0.1) * fuelConsumption;
                return rate;
            }
        }
    }
}