using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        

        public override void DriveAbstract()
        {
            Console.WriteLine("The Motorcycle is driving...");
        }
        public void HasSideCar()
        {
            Console.WriteLine("This vehicle is a motorcycle and has a sidecar.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This is the override Drive method.");
        }
    }
}
