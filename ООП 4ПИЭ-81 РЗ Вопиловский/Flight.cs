using Microsoft.TeamFoundation.Work.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ООП_4ПИЭ_81_РЗ_Вопиловский
{
    public class Flight
    {
        private Airport target;
        private Airport start;
        private int x;
        private int y;
        private object board;

        Flight(Airport target, Airport start, object board)
        {
            this.target = target;
            this.start = start;
            this.board = board;

        }
    }
}