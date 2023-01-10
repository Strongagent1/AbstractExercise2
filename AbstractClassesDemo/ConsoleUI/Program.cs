using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*
* Todo follow all comments!! 
*/

#region Vehicles

/*
 * Create an abstract class called Vehicle-DONE
 * The vehicle class shall have three string properties Year, Make, and Model-DONE
 * Set the defaults to something generic in the Vehicle class-DONE
 * Vehicle shall have an abstract method called DriveAbstract with no implementation-DONE
 * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-DONE
 */

/* 
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle-DONE
 * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle-DONE
 * Provide the implementations for the abstract methods-DONE
 * Only in the Motorcycle class will you override the virtual drive method-DONE
*/

// Create a list of Vehicle called vehicles-DONE
var vehiclesList = new List<Vehicle>();
var car1 = new Car()
{
    Year = "2020",
    Make = "GMC",
    Model = "Yukon XL",
};
var motorcycle1 = new Motorcycle()
{
    Year = "2004",
    Make = "Suzuki",
    Model = "ZX9000",

};
Vehicle vehicle1 = new Car()
{
    Year = "2019",
    Make = "Cadillac",
    Model = "Escalade",
};
Vehicle vehicle2 = new Motorcycle()
{
    Year = "1967",
    Make = "Harley Davidson",
    Model = "Roadster",
};


vehiclesList.Add(car1);
vehiclesList.Add(motorcycle1);
vehiclesList.Add(vehicle1);
vehiclesList.Add(vehicle2);

foreach (var item in vehiclesList)
{
    Console.WriteLine($"Year: {item.Year}");
    Console.WriteLine($"Make: {item.Make}");
    Console.WriteLine($"Model: {item.Model}");
    item.DriveAbstract();
    item.DriveVirtual(); 
    Console.WriteLine("--------------------");
}

/*
 * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
 * 
 * Set the properties with object initializer syntax-DONE
 */

/*
 * Add the 4 vehicles to the list-DONE
 * Using a foreach loop iterate over each of the properties-DONE
 */

// Call each of the drive methods for one car and one motorcycle-DONE

#endregion

