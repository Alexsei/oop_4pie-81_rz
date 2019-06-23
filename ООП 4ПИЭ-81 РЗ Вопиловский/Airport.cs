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
        private int type;      // тип аэропорта: 1 - гражданский, 0 - военный

        public Airport(string name , int maxDocks, int x, int y, int type)
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

        public int FreeDocks // свободных доков
        {
            get            {
                return this.maxDocks - this.busyDocks;
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

        public bool addAirInDock(Aircraft air)
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
                        this.busyDocks++;
                        Console.WriteLine(air.Name);
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
