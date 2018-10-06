using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Storage
{
    class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int garageSlot = 2;
        public AutomatedWarehouse(string name) : base(name, capacity, garageSlot, new List<Vehicle>() {new Truck()})
        {
        }
    }
}
