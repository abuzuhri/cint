using System;
using System.Collections.Generic;
using System.Text;

namespace Se.Cint.Robot.Business.Entity
{
    public class RobotJob
    {
        public int numberOfCommands { get; set; }
        public Coordinate coordinate { get; set; }
        public IList<Location> locations { get; set; }
    }
}
