using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Entity
{
    public class Input
    {
        public string RoverLocation { get; set; }
        public string RoverStep { get; set; }
    }
    public class Output
    {
        public string RoverLastLocation { get; set; }
    }
}
