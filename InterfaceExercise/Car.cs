using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car
    {
        public Car()
        {
        }
        public string Trunk { get; set; }
        public string FuelEconomy { get; set; }
        public string Logo { get; set; }
        public string Product { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Year { get; set; }
        public bool Wheels { get; set; }
    }
}

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */
