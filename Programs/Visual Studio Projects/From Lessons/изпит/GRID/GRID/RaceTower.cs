using GRID.Drivers;
using GRID.Tyres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID
{
    class RaceTower
    {
        public int LapsNumber;
        public int TrackLength;
        public int CurrentLap;
        public List<Driver> RegistredDrivers = new List<Driver>();

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            this.LapsNumber = lapsNumber;
            this.TrackLength = trackLength;
        }

        public void RegisterDriver(List<string> commandArgs)
        {
            if(commandArgs[4] == "Ultrasoft")
            {
                if (commandArgs[0] == "Aggressive")
                {
                    RegistredDrivers.Add(new AggressiveDriver(commandArgs[1], int.Parse(commandArgs[2]), double.Parse(commandArgs[3]), double.Parse(commandArgs[5]), double.Parse(commandArgs[6])));
                }
                else if (commandArgs[0] == "Endurance")
                {
                    RegistredDrivers.Add(new EnduranceDriver(commandArgs[1], int.Parse(commandArgs[2]), double.Parse(commandArgs[3]), double.Parse(commandArgs[5]), double.Parse(commandArgs[6])));
                }
            }
            else if(commandArgs[4] == "Hard")
            {
                if (commandArgs[0] == "Aggressive")
                {
                    RegistredDrivers.Add(new AggressiveDriver(commandArgs[1], int.Parse(commandArgs[2]), double.Parse(commandArgs[3]), double.Parse(commandArgs[5])));
                }
                else if (commandArgs[0] == "Endurance")
                {
                    RegistredDrivers.Add(new EnduranceDriver(commandArgs[1], int.Parse(commandArgs[2]), double.Parse(commandArgs[3]), double.Parse(commandArgs[5])));
                }
            }
        }

        ////public void DriverBoxes(List<string> commandArgs)
        //{
        //    string reasonToBox = commandArgs[0];
        //    string driversName = commandArgs[1];
        //    switch (reasonToBox)
        //    {
        //        case "ChangeTyres":
        //            string tyreType = commandArgs[2];
        //            double tyreHardness = double.Parse(commandArgs[3]);
        //            if (tyreType == "Ultrasoft")
        //            {
        //                double grip = double.Parse(commandArgs[4]);
        //            }
        //            break;
        //        case "Refuel":
        //            double fuelAmount = double.Parse(commandArgs[3]);
        //            break;
        //        default:
        //            break;
        //    }
            
        //}//ne nosi

        public string CompleteLaps(List<string> commandArgs)
        {
            int nuberOfLaps = int.Parse(commandArgs[0]);
            CurrentLap += nuberOfLaps;
            if (CurrentLap > LapsNumber)
            {
                return $"On lap {LapsNumber}.";
            }
            else
            {
                for (int i = 1; i <= nuberOfLaps; i++)
                {

                    foreach (var item in RegistredDrivers)
                    {
                        // увеличаваме времето
                        double currentTime = item.TotalTime;
                        item.TotalTime = currentTime + 60 / (TrackLength / item.Speed);
                        // намаляваме горивото
                        double currentFuel = item.Car.FuelAmount;
                        item.Car.FuelAmount = item.Car.FuelAmount - (TrackLength * item.FuelConsumptionPerKm);
                        // деградираме гумата
                        if (item.Car.Tyre.Name == "Ultrasoft")
                        {
                            UltrasoftTyre tyre = (UltrasoftTyre)item.Car.Tyre;
                            double currentDegradation = item.Car.Tyre.Degradation;
                            item.Car.Tyre.Degradation = currentDegradation - (item.Car.Tyre.Hardness + tyre.Grip);
                        }
                        else
                        {
                            double currentDegradation = item.Car.Tyre.Degradation;
                            item.Car.Tyre.Degradation = currentDegradation - item.Car.Tyre.Hardness;
                        }
                    }
                }
            }
            // това не е елегантно
            return null;
        }

        public string GetLeaderboard()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"Lap {CurrentLap}/{LapsNumber}");
            s.Append(Environment.NewLine);

            // {position} {driverName} {totalTime/failureReason}
            for (int i = 0; i < RegistredDrivers.Count; i++)
            {
                s.Append($"i {RegistredDrivers[i].Name}/{RegistredDrivers[i].TotalTime}");
            }

            return s.ToString();
        }
    }
}
