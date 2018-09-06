namespace _01.Vehicles
{
    using System;
    using System.Dynamic;

    public class Startup
    {
        public static void Main()
        {
            var vehicleInfo = Console.ReadLine().Split(' ');
            var car = new Car(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]));

            vehicleInfo = Console.ReadLine().Split(' ');
            var truck = new Truck(double.Parse(vehicleInfo[1]), double.Parse(vehicleInfo[2]));
            var commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
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
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
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
            }
        }
    }
}
