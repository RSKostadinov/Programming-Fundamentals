using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        VehicleCatalog catalog = new VehicleCatalog();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split("/");

            string type = arguments[0];
            string brand = arguments[1];
            string model = arguments[2];

            if (type == "Car")
            {
                catalog.Cars.Add(new Car
                {
                    Brand = brand,
                    Model = model,
                    HorsePower = int.Parse(arguments[3])

                });
            }
            else
            {
                catalog.Trucks.Add(new Truck
                {
                    Model = model,
                    Brand = brand,
                    Weight = int.Parse(arguments[3])
                });
            }
        }

        if (catalog.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }
        if (catalog.Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");
            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}

class VehicleCatalog
{
    public VehicleCatalog() 
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }
    public List<Car> Cars { get; set; }

    public List<Truck> Trucks { get; set; }
}

class Car
{

    public string Brand { get; set; }

    public string Model { get; set; }

    public decimal HorsePower { get; set; }

}
class Truck
{

    public string Brand { get; set; }

    public string Model { get; set; }

    public int Weight { get; set; }

}