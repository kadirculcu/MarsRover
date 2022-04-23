using MarsRover.Service;
using System;
using Xunit;

namespace Test.MarsRover
{
    public class CalculationTest
    {
        [Fact]
        public void xCordinateCalculateTest()
        {
            int roverx = 2;
            int coordinatex = 3;
            string roverDirection = "E";

            Calculation calculation = new Calculation();

            int result = calculation.xCordinateCalculate(roverDirection, roverx, coordinatex);
       
            Assert.Equal(3, result);
        }
        [Fact]
        public void yCordinateCalculateTest()
        {
            int rovery = 3;
            int coordinatey = 4;
            string roverDirection = "S";

            Calculation calculation = new Calculation();

            int result = calculation.yCordinateCalculate(roverDirection, rovery, coordinatey);

            Assert.Equal(2, result);
        }
        [Fact]
        public void directionCalculateTest()
        {
            string roverStep = "R";
            string roverDirection = "N";

            Calculation calculation = new Calculation();

            string result = calculation.directionCalculate(roverStep, roverDirection);

            Assert.Equal("E", result);
        }
    }
}
;