using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is now in drive!");

        }

        public bool HasAirbags { get; set; }

    }
}
