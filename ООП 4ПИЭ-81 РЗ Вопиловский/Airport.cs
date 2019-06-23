using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    class Airport
    {
        private int x;           // координата  X
        private int y;           // координата  Y
        private int runway = 1;  // Взлетно посадочных полос
        private int maxDocks;      // Места стоянки самолетов
        private int busyDocks = 0; // количество занятых доков
        private string name;      // наименование аэропорта
        private Docks[] airDocks; // массив доков для самолетов

        public Airport(string name , int maxDocks, int x, int y)
        {
            this.name = name;
            this.maxDocks = maxDocks;
            this.x = x;
            this.y = y;
            this.airDocks = new Docks[maxDocks];
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

        public string Name
        {
            get            {
                return this.name;
            }
        }

        public int FreeDocks
        {
            get            {
                return this.maxDocks - this.busyDocks;
            }
        }

        public bool addAirInDock(Aircraft air)
        {
            if (this.busyDocks != 0)
            {
                for (int i = 0; i < airDocks.Length; i++)
                {
                    if (airDocks[i].Status == 0)  // если док свободен
                    {
                        airDocks[i].Status = 1;
                        airDocks[i].ServiceTime = air.ServTime;
                        airDocks[i].Air = air;
                        this.busyDocks--;
                        Console.WriteLine("гуд");
                        return true;
                        break;
                    }
                }
                return false;
            } else { return false; }
        }
    }

    public class Docks
    {
        private int status;      // 0- свободен  ; 1- обслуживание  ;  2 - готовый
        private int serviceTime; // осталось времени на обслуживание
        private Aircraft air = null;  // самолет

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
