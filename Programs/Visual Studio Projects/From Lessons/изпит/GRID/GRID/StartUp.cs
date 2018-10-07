using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace GRID
{
    class Program
    {
        static void Main(string[] args)
        {
            int tracklength = int.Parse(Console.ReadLine());
            int lapsnumb = int.Parse(Console.ReadLine());

            var a = new RaceTower();
            a.SetTrackInfo(tracklength, lapsnumb);
            while (true)
            {
                if (a.CurrentLap == a.LapsNumber) break;
                List<string> commandsargs = Console.ReadLine().Split(' ').ToList();
                if (commandsargs[0] == "RegisterDriver")
                {
                    a.RegisterDriver(commandsargs);
                }
                if (commandsargs[0] == "Leaderboard")
                {
                    a.GetLeaderboard();

                }
                if (commandsargs[0] == "CompleteLaps")
                {
                    a.CompleteLaps(commandsargs);
                }
                if (commandsargs[0] == "Box")
                {
                    a.DriverBoxes(commandsargs);

                }
            }
            a.RegistredDrivers= a.RegistredDrivers.OrderBy(order => order.TotalTime).ToList();
            Console.WriteLine("{0} wins the race for {1:F3} seconds.", a.RegistredDrivers[0].Name, a.RegistredDrivers[0].TotalTime); ;
            //           Thread.Sleep(50000);
        }
    }
}