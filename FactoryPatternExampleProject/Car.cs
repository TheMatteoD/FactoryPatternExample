using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExampleProject
{
    internal class Car : IVehicle
    {
        public int NumberOfTires = 4;
        public bool HasSunRoof { get; set; }
        public void Drive()
        {
            Console.WriteLine("The car is now in drive!");
            
        }
    }
}
