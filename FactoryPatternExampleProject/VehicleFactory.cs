using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExampleProject
{
    internal class VehicleFactory
    {
        public static void GetVehicle()
        {
            //User selects their vehicle 
            Console.WriteLine("What type of vehicle would you like, car or bike?");
            var userInput = Console.ReadLine();

            //creates selected vehicle
            switch (userInput.ToLower())
            {
                case "car":
                    var myCar = new Car();
                    break;
                case "bike":
                    var myBike = new Bike();
                    break;
                default:
                    break;
            }
        }
    }
}
 