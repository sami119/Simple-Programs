using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Drivers
{
    class EnduranceDriver : Driver 
    {
        private const double fuelConsumptionPerKm = 1.5;

        public EnduranceDriver(string name, int hp, double fuelAmount, double tyreHardness) : base(name, hp, fuelAmount, tyreHardness)
        {
            base.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public EnduranceDriver(string name, int hp, double fuelAmount, double tyreHardness, double grip) : base(name, hp, fuelAmount, tyreHardness, grip)
        {
            base.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
    }
}
