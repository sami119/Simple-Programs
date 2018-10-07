using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Drivers
{
    class AggressiveDriver : Driver //dovyrshi
    {
        private const double fuelConsumptionPerKm = 2.7;
        private const double speedMultiplayer = 1.3;

        public AggressiveDriver(string name, int hp, double fuelAmount, double tyreHardness) :base(name, hp, fuelAmount, tyreHardness)
        {
            base.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public AggressiveDriver(string name, int hp, double fuelAmount, double tyreHardness, double grip) : base(name, hp, fuelAmount, tyreHardness, grip)
        {
            base.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
    }
}
