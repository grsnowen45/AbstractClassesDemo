using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             *done Create an abstract class called Vehicle
             *done The vehicle class shall have three string properties Year, Make, and Model
             *done Set the defaults to something generic in the Vehicle class
             *done Vehicle shall have an abstract method called DriveAbstract with no implementation
             *done Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *done Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *done Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *done Provide the implementations for the abstract methods
             *done Only in the Motorcycle class will you override the virtual drive method
            */

            //done Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             *done Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *done - new it up as one of each derived class
             *done Set the properties with object initializer syntax
             */
            var civic = new Car() { HasAirbags = true, Make = "Honda", Model = "Accord", Year = 2008 };
            var harley = new Motorcycle() { HasHandlebars = true, Make = "Harley Davidson", Model = "bikey", Year = 1969 };

            Vehicle mustang = new Car() { HasAirbags = false, Make = "Ford", Model = "Mustang", Year = 1980 };
            Vehicle dirtbike = new Motorcycle() { HasHandlebars = true, Make = "Kawasaki", Model = "Ninja", Year = 2021 };



            /*
             *done Add the 4 vehicles to the list
             *done Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(civic);
            vehicles.Add(harley);
            vehicles.Add(mustang);
            vehicles.Add(dirtbike);


            foreach(var vhc in vehicles)
            {
                Console.WriteLine($"Make: {vhc.Make} Model: {vhc.Model} Year: {vhc.Year}");
                vhc.DriveVirtual();
                Console.WriteLine("     ");
            }
            //done Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
