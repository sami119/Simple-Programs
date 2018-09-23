using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        private int garageSlots;
        public int GarageSlots
        {
            get
            {
                return this.garageSlots;
            }
            set
            {
                this.garageSlots = value;
            }
        }

        public IReadOnlyCollection<Vehicle> Garage { get; set; }
        public IReadOnlyCollection<Product> Products { get; set; }

        public bool IsFull => Products.Sum(x => x.Weight) >= Capacity;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.name = name;
            this.capacity = capacity;
            this.garageSlots = garageSlots;

            this.Garage = vehicles.ToList().AsReadOnly();
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= garageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            Vehicle[] vehicles = this.Garage.ToArray();
            if (vehicles[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return vehicles[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle[] vehicles = this.Garage.ToArray();
            if (garageSlot >= GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if(vehicles[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            Vehicle[] delivery = deliveryLocation.Garage.ToArray();
            for (int i = 0; i < delivery.Length; i++)
            {
                if (!(delivery[i] == null))
                {
                    throw new InvalidOperationException("No room in garage!");
                }
            }
            var vehicle = GetVehicle(garageSlot);
            vehicles[garageSlot] = null;

            int assignedTo = 0;
            for (int i = 0; i < delivery.Length; i++)
            {
                if (delivery[i] == null)
                {
                    delivery[i] = vehicle;
                    assignedTo = i;
                    break;
                }
            }
            this.Garage = vehicles;
            deliveryLocation.Garage = delivery;

            return assignedTo;

        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle vehicle = GetVehicle(garageSlot);
            List<Product> list = Products.ToList();
            var count = 0;
            while (vehicle.IsEmpty && !this.IsFull)
            {
                list.Add(vehicle.Unload());
                count++;
            }
            Products = list.AsReadOnly();
            return count;
        }
    }
}
