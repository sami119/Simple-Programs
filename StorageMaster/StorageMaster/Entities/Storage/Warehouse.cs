using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Storage
{
    class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int garageSlot = 10;
        public Warehouse(string name) : base(name, capacity, garageSlot, new List<Vehicle>() { new Semi(), new Semi(), new Semi() })
        {
        }
    }
}
