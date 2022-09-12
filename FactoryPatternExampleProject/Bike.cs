using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExampleProject
{
    internal class Bike : IVehicle
    {
        public int NumberOfTires = 2;
        public string Name { get; set; }
        public void Drive()
        {
            Console.WriteLine("The bike is now in drive!");
        }
    }
}
