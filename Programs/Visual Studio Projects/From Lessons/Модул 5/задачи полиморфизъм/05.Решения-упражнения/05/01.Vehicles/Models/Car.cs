namespace _01.Vehicles
{
    using System;

    public class Car : Vehicle
    {
        private const double ConsumptionModifier = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption + Car.ConsumptionModifier)
        {
        }
    }
}
