using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Storage
{
    class DistributionCenter : Storage
    {
        private const int capacity = 2;
        private const int garageSlot = 5;
        public DistributionCenter(string name) : base(name, capacity, garageSlot, new List<Vehicle>() { new Van(), new Van(), new Van()})
        {
        }
    }
}
