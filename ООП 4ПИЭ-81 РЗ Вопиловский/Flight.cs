using Microsoft.TeamFoundation.Work.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class Flight  // рейс
    {
        private Airport target;  // цель полета
        private Airport start;   // место отправления
        private int x;           // местоположение X
        private int y;           // местоположение Y
        private Aircraft board;  // Самолет
        private double flightTime;  // остаток времени полета

        public Flight(Airport target, Airport start, Aircraft board)
        {
            this.target = target;
            this.start = start;
            this.board = board;
            this.x = start.X;
            this.y = start.Y;
            this.flightTime = board.FlightTime;
        }

        public Aircraft Board { get { return this.board; } }
        public Airport Start { get { return this.start; } }
        public Airport Target { get { return this.target; } }
        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }

        public double FlightTime { get { return this.flightTime; } }

        public bool step()
        {
            int targetX = target.X;
            int targetY = target.Y;
            double range = Math.Sqrt((targetX - x) * (targetX - x) + (targetY - y) * (targetY - y)); // расcтояние до цели
            this.flightTime = this.flightTime - (Convert.ToDouble(this.board.Weight + this.board.Cargo) / this.board.Weight);
            Console.WriteLine(this.flightTime);

            if (range <= board.Speed) 
            {
                this.x = targetX;
                this.y = targetY;
            } else if (range > board.Speed)
            {
                double step = range / board.Speed;
                this.x = Convert.ToInt32(((targetX - this.x) / step)) + this.x;
                this.y = Convert.ToInt32(((targetY - this.y) / step)) + this.y;
            }
            if (this.flightTime > 0 ) // если есть время
            {
                this.flightTime = this.flightTime - (Convert.ToDouble(this.board.Weight + this.board.Cargo) / this.board.Weight);
                return true;        // вернуть полет нормально
            } else
            {
                this.flightTime = 0;
                return false;      // вернуть самолет терпит крушение
            }
            
        }
    }
}