using GRID.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Drivers
{
    abstract class Driver
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        private double totalTime;
        public double TotalTime
        {
            get
            {
                return totalTime;
            }
            set
            {
                this.totalTime = value;
            }
        }

        private Car car;    
        public Car Car
        {
            get
            {
                return car;
            }
            set
            {
                this.car = value;
            }
        }

        private double fuelConsumptionPerKm;
        public double FuelConsumptionPerKm
        {
            get
            {
                return fuelConsumptionPerKm;
            }
            set
            {
                this.fuelConsumptionPerKm = value;
            }
        }

        private double speed;
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                this.speed = value;
            }
        }//dovyrshi

        protected Driver(string name, int hp, double fuelAmount, double tyreHardness, double grip)
        {
            this.name = name;
            car = new Car(hp, fuelAmount, tyreHardness, grip);
            Speed = (car.Hp + car.Tyre.Degradation) / car.FuelAmount; 
        }
        protected Driver(string name, int hp, double fuelAmount, double tyreHardness)
        {
            this.name = name;
            car = new Car(hp, fuelAmount, tyreHardness);
            Speed = (car.Hp + car.Tyre.Degradation) / car.FuelAmount;
        }
    }
}
