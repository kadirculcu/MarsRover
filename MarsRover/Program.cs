using MarsRover.Entity;
using MarsRover.Service;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Cordinate coordinate = new Cordinate();
            Processing processing = new Processing();
            List<Input> inputs = new List<Input>();
            List<Output> outputs = new List<Output>();
            string inputLine;
            string inputData = "";

            do
            {
                Console.WriteLine("Input");
                string cordinate = Console.ReadLine();            
                coordinate = processing.cordinateProcess(cordinate);
                if (coordinate.ErrorMessage != null)
                {
                    Console.WriteLine(coordinate.ErrorMessage);
                }
            } while (coordinate.ErrorMessage != null);
           
            while (!String.IsNullOrWhiteSpace(inputLine = Console.ReadLine()))
            {
                inputData = inputData + "+" + inputLine;
            }

            string[] inputDataChar = inputData.Split('+');
            for (int i = 1; i < inputDataChar.Length-1; i+=2)
            {
                inputs.Add(new Input() { RoverLocation = inputDataChar[i], RoverStep = inputDataChar[i+1] });
            }
        
            foreach (var input in inputs)
            {
                Calculation calculation = new Calculation();
                List<string> roverSteps = new List<string>();
                string roverLastLocation = "";
                RoverLocation roverLocation = processing.roverLocationProcess(input.RoverLocation, coordinate.Coordinatex, coordinate.Coordinatey);
                if (roverLocation.ErrorMessage != null)
                {
                    roverLastLocation = roverLocation.ErrorMessage;
                }
                else
                {
                    for (int i = 0; i <= input.RoverStep.Length - 1; i++)
                    {
                        roverSteps.Add(input.RoverStep[i].ToString());
                    }
                    foreach (var roverStep in roverSteps)
                    {
                        if (roverStep == "M")
                        {
                            roverLocation.Roverx = calculation.xCordinateCalculate(roverLocation.RoverDirection, roverLocation.Roverx, coordinate.Coordinatex);
                            roverLocation.Rovery = calculation.yCordinateCalculate(roverLocation.RoverDirection, roverLocation.Rovery, coordinate.Coordinatey);
                        }
                        else
                        {
                            roverLocation.RoverDirection = calculation.directionCalculate(roverStep, roverLocation.RoverDirection);
                        }
                        roverLastLocation = calculation.lastLocationFormat(roverLocation.Roverx, roverLocation.Rovery, roverLocation.RoverDirection);
                    }
                }      
                outputs.Add(new Output() { RoverLastLocation = roverLastLocation });
            }
            Console.WriteLine("Output");
            foreach (var output in outputs)
            {
                Console.WriteLine(output.RoverLastLocation);
            }
        }
    }
}
