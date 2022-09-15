using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Train
    {
        private readonly string destination;
        private readonly int number;
        private readonly DateTime departureTime;

        public Train(string destination, int number, DateTime departureTime)
        {
            this.destination = destination;
            this.number = number;
            this.departureTime = departureTime;
        }

        public string Destination { get { return destination; } }
        public int Number { get { return number; } }
        public DateTime DepartureTime { get { return departureTime; } }
    }
}
