namespace _02.Vehicles_Extension
{
    using System;

    public class Car : Vehicle
    {
        private const double ConsumptionModifier = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + Car.ConsumptionModifier, tankCapacity) {}

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
    }
}
