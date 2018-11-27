using System;
using System.Collections.Generic;
using System.Text;

namespace Se.Cint.Robot.Business.Entity
{
    public class Coordinate
    {
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x { get; set; }
        public int y { get; set; }
    }
}
