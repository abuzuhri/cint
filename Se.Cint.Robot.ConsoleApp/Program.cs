using Se.Cint.Robot.Business.Entity;
using Se.Cint.Robot.Business.Service;
using System;
using System.Collections.Generic;
using static Se.Cint.Robot.Business.Util.Constants;

namespace Se.Cint.Robot.ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RobotJob robotJob = new RobotJob();
            robotJob.numberOfCommands = readNumberOfCommands();
            robotJob.coordinate = readCoordinate();
            robotJob.locations = readLocations(robotJob.numberOfCommands);

            int cleaningPoint= CleaningService.StartNewJob(robotJob);
            Console.WriteLine("=> cleaned: " + cleaningPoint);

        }
        public static IList<Location> readLocations(int numberOfCommands)
        {
            IList<Location> locations = new List<Location>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                Location location = new Location();
                
                string locationStr = Console.ReadLine();
                string[] locationParts = locationStr.Split(' ');
                Direction direction ;
                if (Enum.TryParse(locationParts[0], out direction))
                    location.direction = direction;
                location.step= int.Parse(locationParts[1]);
                locations.Add(location);
            }
            return locations;
        }
        public static int readNumberOfCommands()
        {
            return int.Parse(Console.ReadLine());
        }
        public static Coordinate readCoordinate()
        {
            string coordinateStr = Console.ReadLine();
            string[] coordinates = coordinateStr.Split(' ');
            int coordinate_x = int.Parse(coordinates[0]);
            int coordinate_y = int.Parse(coordinates[1]);
            return new Coordinate(coordinate_x, coordinate_y);
        }
    }
}
