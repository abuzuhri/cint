using Microsoft.VisualStudio.TestTools.UnitTesting;
using Se.Cint.Robot.Business.Entity;
using Se.Cint.Robot.Business.Service;
using System.Collections.Generic;

namespace Se.Cint.Robot.Test
{
    [TestClass]
    public class RobotTest1
    {
        [TestMethod]
        public void FinalJobTest()
        {
            RobotJob robotJob = new RobotJob();
            robotJob.coordinate = new Coordinate(10,22);

            robotJob.locations = new List<Location>();
            robotJob.locations.Add(new Location(Business.Util.Constants.Direction.E, 2));
            robotJob.locations.Add(new Location(Business.Util.Constants.Direction.N, 1));

            int cleaningPoint = CleaningService.StartNewJob(robotJob);
            Assert.AreEqual(4, cleaningPoint);


        }
    }
}
