using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car hondaCivic = new Car()
            {
                FuelEconomy = "30MPG",
                Trunk = "13 cubic-ft",
                Year = 2010,
                Make = "Honda",
                Model = "Civic",
                Logo = "Honda Emblem",
                Product = "Cars",
                DriveTrain = "FWD"
            };

            Truck toyotaTacoma = new Truck()
            {
                BedSize = "73 in",
                TowCapacity = "3500 lbs",
                Year = 2014,
                Make = "Toytoa",
                Model = "Tacoma",
                Logo = "Toyota Emblem",
                Product = "Truck",
                DriveTrain = "4WD"
            };

            SUV lexusGX470 = new SUV()
            {
                CargoHoldSize = "77 cubic-ft",
                GroundClearance = "8.3 in",
                Year = 2007,
                Make = "Lexus",
                Model = "GX470",
                Logo = "Lexus Emblem",
                Product = "SUV",
                DriveTrain = "AWD"
            };



            {
                //Console.WriteLine($"HONDA CIVIC");
                //Console.WriteLine($"Year: {hondaCivic.Year}");
                //Console.WriteLine($"Make: {hondaCivic.Make}");
                //Console.WriteLine($"Model: {hondaCivic.Model} ");
                //Console.WriteLine($"Logo: {hondaCivic.Logo} ");
                //Console.WriteLine($"Product: {hondaCivic.Product}");
                //Console.WriteLine($"Drive Train: {hondaCivic.DriveTrain}");
                //Console.WriteLine($"Fuel Economy: {hondaCivic.FuelEconomy}");
                //Console.WriteLine($"Trunk Space: {hondaCivic.Trunk}");
                //Console.WriteLine("----------------------------------");
                //Console.WriteLine();

                //Console.WriteLine($"TOYOTA TACOMA");
                //Console.WriteLine($"Year: {toyotaTacoma.Year}");
                //Console.WriteLine($"Make: {toyotaTacoma.Make}");
                //Console.WriteLine($"Model: {toyotaTacoma.Model} ");
                //Console.WriteLine($"Logo: {toyotaTacoma.Logo} ");
                //Console.WriteLine($"Product: {toyotaTacoma.Product}");
                //Console.WriteLine($"Drive Train: {toyotaTacoma.DriveTrain}");
                //Console.WriteLine($"BedSize: {toyotaTacoma.BedSize}");
                //Console.WriteLine($"Tow Capacity:{toyotaTacoma.TowCapacity}");
                //Console.WriteLine("----------------------------------");
                //Console.WriteLine();

                //Console.WriteLine($"LEXUS GX470");
                //Console.WriteLine($"Year: {lexusGX470.Year}");
                //Console.WriteLine($"Make: {lexusGX470.Make}");
                //Console.WriteLine($"Model: {lexusGX470.Model} ");
                //Console.WriteLine($"Logo: {lexusGX470.Logo} ");
                //Console.WriteLine($"Product: {lexusGX470.Product}");
                //Console.WriteLine($"Drive Train: {lexusGX470.DriveTrain}");
                //Console.WriteLine($"Cargo Hold Size: {lexusGX470.CargoHoldSize}");
                //Console.WriteLine($"Ground Clearance: {lexusGX470.GroundClearance}");
                //Console.WriteLine("----------------------------------");
                //Console.WriteLine();

                

            }
        }
    }
}
