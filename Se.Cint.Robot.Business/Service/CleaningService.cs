using Se.Cint.Robot.Business.Entity;
using Se.Cint.Robot.Business.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Se.Cint.Robot.Business.Util.Constants;

namespace Se.Cint.Robot.Business.Service
{
    public class CleaningService
    {
        public static int StartNewJob(RobotJob robotJob)
        {


            IList<Coordinate> places = new List<Coordinate>();
            Coordinate currentCoordinate = robotJob.coordinate;
            places.Add(currentCoordinate);
            foreach (var location in robotJob.locations)
            {
                for(int i=1; i<= location.step; i++)
                {
                    currentCoordinate = CalcNexCoordinate(currentCoordinate, location.direction);
                    places.Add(new Coordinate(currentCoordinate.x, currentCoordinate.y));
                }
            }

            return places.Distinct().Count();
        }

        private static Coordinate CalcNexCoordinate(Coordinate currentCoordinate, Direction direction)
        {
            Coordinate nexCoordinate = currentCoordinate;
            if (direction == Util.Constants.Direction.S)
                nexCoordinate.x = nexCoordinate.x - 1;
            else if (direction == Util.Constants.Direction.N)
                nexCoordinate.x = nexCoordinate.x + 1;
            else if(direction == Util.Constants.Direction.E)
                nexCoordinate.y = nexCoordinate.y - 1;
            else if(direction == Util.Constants.Direction.W)
                nexCoordinate.y = nexCoordinate.y + 1;
            if (IsValidPlace(nexCoordinate))
                return nexCoordinate;
            else return currentCoordinate;
        }

        private static bool IsValidPlace(Coordinate nexCoordinate)
        {
            if (Constants.MAX_X >= nexCoordinate.x && nexCoordinate.x >= -1 * Constants.MAX_X
                && Constants.MAX_Y >= nexCoordinate.y && nexCoordinate.y >= -1 * Constants.MAX_Y)
                return true;
            else return false;


        }
    }
}
