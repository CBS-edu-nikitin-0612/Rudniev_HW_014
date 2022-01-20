using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("Audi TT 2.0 TFSI quattro", 25000, 243, 2012, 2) as Vehicle);
            vehicles.Add(new Plane("Boeing 737", 2160000, 900, 2014, 189, 12500) as Vehicle);
            vehicles.Add(new Ship("Azimut S7", 2320000, 67, 2018, 14, "Odessa") as Vehicle);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
                //vehicle.Show();
                Console.WriteLine(new string('_', 50));
            }
        }
    }
}
