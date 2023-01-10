using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

  
        public override void DriveAbstract()
        {
            Console.WriteLine("The Car is driving....");
        }
        public void HasTrunk()
        {
            Console.WriteLine("This vehicle is a car and has a trunk.");
        }
    }
}
