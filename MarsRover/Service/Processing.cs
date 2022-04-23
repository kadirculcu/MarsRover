using MarsRover.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service
{
    public class Processing
    {
        public Cordinate cordinateProcess(string coordinate) 
        {
            Cordinate cordinate = new Cordinate();
            string ErrorMessage = "Kordinatlarrı 'x y' formatında x ve y rakam olacak şekilde giriniz.";
            string[] coordinateChar = coordinate.Split(' ');
            if (coordinateChar.Length != 2)
            {
                cordinate.ErrorMessage = ErrorMessage;
                return cordinate;
            }
            try
            {
                cordinate.Coordinatex = Convert.ToInt32(coordinateChar[0].ToString());
                cordinate.Coordinatey = Convert.ToInt32(coordinateChar[1].ToString());
            }
            catch (Exception)
            {
                cordinate.ErrorMessage = ErrorMessage;
                return cordinate;
            }        
            return cordinate;
        }
        public RoverLocation roverLocationProcess(string roverLocation, int coordinatex ,int coordinatey) 
        {
            RoverLocation roverLocationProcess = new RoverLocation();
            string ErrorMessage = "Hatalı Lokasyon Girildi.";
            string[] loacationChar = roverLocation.Split(' ');
            if (loacationChar.Length != 3 )
            {
                roverLocationProcess.ErrorMessage = ErrorMessage;
                return roverLocationProcess;
            }
            try
            {
                roverLocationProcess.Roverx = Convert.ToInt32(loacationChar[0].ToString());
                roverLocationProcess.Rovery = Convert.ToInt32(loacationChar[1].ToString());
                roverLocationProcess.RoverDirection = loacationChar[2].ToString();
            }
            catch (Exception)
            {
                roverLocationProcess.ErrorMessage = ErrorMessage;
                return roverLocationProcess;
            }
            if (roverLocationProcess.Roverx > coordinatex || roverLocationProcess.Roverx < 0 || roverLocationProcess.Rovery > coordinatey || roverLocationProcess.Rovery < 0)
            {
                roverLocationProcess.ErrorMessage = "Lokasyon, Kordinat Alanının Dışındadır.";
                return roverLocationProcess;
            }
            return roverLocationProcess;
        }
    }
}
