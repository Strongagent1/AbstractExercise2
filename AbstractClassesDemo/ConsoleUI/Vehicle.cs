using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Default";

        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("The virtual vehicle is virtually driving.");
        }
    }
}
