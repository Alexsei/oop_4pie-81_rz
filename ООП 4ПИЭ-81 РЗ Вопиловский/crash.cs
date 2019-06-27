using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class Crash  // Крушение
    {
        private int sTime;  // на каком шаге крушение
        private Aircraft board; // самолет
        private Airport start;  // откуда вылетел
        private Airport target; // куда летел 
        private int x;      // место крушения
        private int y;      // 

        public Crash(Flight flight, int sTime)
        {
            this.sTime = sTime;
            this.board = flight.Board;
            this.start = flight.Start;
            this.target = flight.Target;
            this.x = flight.X;
            this.y = flight.Y;
    }
    }
}