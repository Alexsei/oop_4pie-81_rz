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
        private int flightTime;  // остаток времени полета

        Flight(Airport target, Airport start, Aircraft board)
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


        public void step()
        {
            int targetX = target.X;
            int targetY = target.Y;
            double range = Math.Sqrt((targetX - x) * (targetX - x) + (targetY - y) * (targetY - y)); // расcтояние до цели

            board.Fuel = board.Fuel - board.FuelConsumption;
            if (range <= board.Speed)
            {
                this.x = targetX;
                this.y = targetY;
            }
            if (range > board.Speed)
            {
                double step = range / board.Speed;
                this.x = Convert.ToInt32(((targetX - this.x) / step)) + this.x;
                this.y = Convert.ToInt32(((targetY - this.y) / step)) + this.y;
                
            }
        }
    }
}