namespace _02.Vehicles_Extension
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var vehicleInfo = Console.ReadLine().Split(' ');
            var car = new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));

            vehicleInfo = Console.ReadLine().Split(' ');
            var truck = new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));

            vehicleInfo = Console.ReadLine().Split(' ');
            var bus = new Bus(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]), double.Parse(vehicleInfo[3]));

            var commandsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsNumber; i++)
            {
                try
                {
                    var tokens = Console.ReadLine().Split(' ');
                    switch (tokens[1])
                    {
                        case "Car":
                            ExecuteCommand(car, tokens[0], double.Parse(tokens[2]));
                            break;
                        case "Truck":
                            ExecuteCommand(truck, tokens[0], double.Parse(tokens[2]));
                            break;
                        case "Bus":
                            ExecuteCommand(bus, tokens[0], double.Parse(tokens[2]));
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        public static void ExecuteCommand(Vehicle vehicle, string action, double parameter)
        {
            switch (action)
            {
                case "Drive":
                    Console.WriteLine(vehicle.TryTravelDistance(parameter));
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
                case "DriveEmpty":
                    Console.WriteLine(vehicle.TryTravelDistance(parameter, false));
                    break;
            }
        }
    }
}
