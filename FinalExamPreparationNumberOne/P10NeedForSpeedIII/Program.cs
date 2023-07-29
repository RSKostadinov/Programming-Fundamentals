
internal class Program
{
    static void Main()
    {
        Dictionary<string, Car> carDictionary = new Dictionary<string, Car>();

        int numberOfCars = int.Parse(Console.ReadLine());
        string carModel;
        int carMileage;
        int carFuel;

        string input;
        for (int i = 0; i < numberOfCars; i++)
        {
            input = Console.ReadLine();
            string[] carDetails = input.Split('|');
            carModel = carDetails[0];
            carMileage = int.Parse(carDetails[1]);
            carFuel = int.Parse(carDetails[2]);

            carDictionary.Add(carModel, new Car(carModel));
            carDictionary[carModel].Mileage = carMileage;
            carDictionary[carModel].Fuel = carFuel;
            //Console.WriteLine($"{carModel}|{carMileage}|{carFuel}");
        }

        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] arguments = input.Split(" : ");
            string command = arguments[0];
            string car = arguments[1];

            switch (command)
            {

                case "Drive": // car : distance : fuel
                    int distance = int.Parse(arguments[2]);
                    int fuel = int.Parse(arguments[3]);
                    if (carDictionary[car].Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carDictionary[car].Mileage += distance;
                        carDictionary[car].Fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (carDictionary[car].Mileage > 100000)
                    {
                        string keyToRemove = car;
                        Console.WriteLine($"Time to sell the {car}!");
                        carDictionary.Remove(keyToRemove);
                    }

                    break;
                case "Refuel":// car : fuel
                    fuel = int.Parse(arguments[2]);
                    
                    if ((carDictionary[car].Fuel + fuel) > 75)
                    {
                        fuel = 75 - carDictionary[car].Fuel;
                        carDictionary[car].Fuel = 75;
                    }
                    else
                    {
                        carDictionary[car].Fuel += fuel;
                    }
                    Console.WriteLine($"{car} refueled with {fuel} liters");
                    break;
                case "Revert":// car : kilometers
                    int kilometers = int.Parse(arguments[2]);
                    carDictionary[car].Mileage -= kilometers;
                    if (carDictionary[car].Mileage < 10000)
                    {
                        carDictionary[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }

                    break;
            }
        }
        foreach (var car in carDictionary.Values)
        {

            Console.WriteLine($"{car.CarModel} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
        }
    }
}
class Car
{
    public Car(string carModel)
    {
        CarModel = carModel;

    }

    public string CarModel { get; set; }

    public int Mileage { get; set; }

    public int Fuel { get; set; }

}