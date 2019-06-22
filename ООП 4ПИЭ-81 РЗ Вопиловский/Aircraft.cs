using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class Aircraft
    {
        private double weight;             // вес самолета: тонн
        private int flightTime;         // максимальное время полета: тик времени
        private int serviceTime;        // время обслуживание в аэропарту:  тик времени
        private int speed;              // рассотояние за один тик времени
        private int maxFuel;            // максимум топлива
        private double fuelConsumption;    // потребление топлива за 1 тик на тонну веса
        private double fuel;               // количество топлива на самолете: тонн

        public Aircraft(double weight, int flightTime, int serviceTime, int speed, int maxFuel, double fuelConsumption, double fuel)
        {
            this.weight = weight;
            this.flightTime = flightTime;
            this.serviceTime = serviceTime;
            this.speed = speed;
            this.maxFuel = maxFuel;
            this.fuelConsumption = fuelConsumption;
            this.fuel = fuel;
        }

        public double rateFuel // текущий расход топлива за тик
        {
            get {
                double rate;
                rate = (weight + fuel) * fuelConsumption;
                return rate;
            }

        }
    }
}