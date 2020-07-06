﻿using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is in drive!");
        }

        public bool HasHandlebars { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a { GetType().BaseType.Name} that is virtually in drive");
        }
    }
}