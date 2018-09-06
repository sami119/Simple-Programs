namespace _02.Vehicles_Extension
{
    using System;

    public class Truck : Vehicle
    {
        private const double ConsumptionModifier = 1.6;
        private const double RefuelingLoss = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + Truck.ConsumptionModifier, tankCapacity) { }
        
       public override void Refuel(double fuelAmount) => base.Refuel(fuelAmount * Truck.RefuelingLoss);
    }
}
