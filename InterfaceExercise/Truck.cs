using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck
    {
        public Truck()
        {
        }
        public string BedSize { get; set; }
        public string TowCapacity { get; set; }
        public string Logo { get; set; }
        public string Product { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Year { get; set; }
        public string DriveTrain { get; set; }
    }
}
/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */