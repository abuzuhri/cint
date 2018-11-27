using System;
using System.Collections.Generic;
using System.Text;
using static Se.Cint.Robot.Business.Util.Constants;

namespace Se.Cint.Robot.Business.Entity
{
    public class Location
    {
        public Direction direction { get; set; }
        public int step { get; set; }
    }
}
