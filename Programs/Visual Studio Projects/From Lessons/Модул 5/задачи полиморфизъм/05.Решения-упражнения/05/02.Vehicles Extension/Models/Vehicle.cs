namespace _02.Vehicles_Extension
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double tankCapacity;
        
        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankcapacity)
        {
            this.TankCapacity = tankcapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        
        public double TankCapacity
        {
            get { return this.tankCapacity; }
            private set { this.tankCapacity = value; }
        }  

        protected double FuelConsumptionPerKm
        {
            get { return this.fuelConsumptionPerKm; }
            private set { this.fuelConsumptionPerKm = value; }
        }  

        protected virtual double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value;}
        }

        protected virtual bool Drive(double distance, bool isAcOn)
        {
            var requiredFuel = distance * this.FuelConsumptionPerKm;
            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }
        
        public string TryTravelDistance(double distance) => TryTravelDistance(distance, true);

        public string TryTravelDistance(double distance, bool isAcOn)
        {
            if (this.Drive(distance, isAcOn))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuelAmount;
        }

        public override string ToString() =>  $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
