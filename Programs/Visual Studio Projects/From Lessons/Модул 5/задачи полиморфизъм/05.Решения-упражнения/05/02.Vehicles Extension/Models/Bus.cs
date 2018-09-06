namespace _02.Vehicles_Extension
{
    using System;

    public class Bus : Vehicle
    {
        private const double ACConsumptionModifier = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity) {}

        protected override double FuelQuantity
        {
            set
            {
                if (value > base.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }

                base.FuelQuantity = value;
            }
        }

        protected override bool Drive(double distance, bool isAcOn)
        {
            double requiredFuel = 0;
            if (isAcOn)
                requiredFuel = distance * (this.FuelConsumptionPerKm + Bus.ACConsumptionModifier);
            else
                requiredFuel = distance * this.FuelConsumptionPerKm;

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }
    }
}