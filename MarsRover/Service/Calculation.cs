using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service
{
    public class Calculation 
    {
        public int xCordinateCalculate(string roverDrection , int roverx , int coordinatex) 
        {
            return roverx = roverDrection == "E" && roverx < coordinatex ? roverx + 1 : roverDrection == "W" && roverx > 0 ? roverx - 1 : roverx;
        }
        public int yCordinateCalculate(string roverDirection , int rovery, int coordinatey)
        {
           return rovery = roverDirection == "N" && rovery < coordinatey ? rovery + 1 : roverDirection == "S" && rovery > 0 ? rovery - 1 : rovery;
        }
        public string directionCalculate(string roverStep, string roverDirection) 
        {
            if (roverStep == "R")
            {
               return roverDirection = roverDirection == "N" ? "E" : roverDirection == "S" ? "W" : roverDirection == "E" ? "S" : roverDirection == "W" ? "N" : roverDirection;
            }
            else 
            {
               return roverDirection = roverDirection == "N" ? "W" : roverDirection == "S" ? "E" : roverDirection == "E" ? "N" : roverDirection == "W" ? "S" : roverDirection;
            }
        }
        public string lastLocationFormat(int roverx,int rovery,string roverDirection)
        {
            return roverx.ToString() + ' ' + rovery.ToString() + ' ' + roverDirection;
        }
    }
}
