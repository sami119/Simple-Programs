using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
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
        
        public IReadOnlyCollection<Product> Trunk
        {
            get;
            set;
        }

        public bool IsFull => Trunk.Sum(x => x.Weight) >= this.Capacity;

        public bool IsEmpty => Trunk.Count == 0;

        public Vehicle(int capacity)
        {
            this.capacity = capacity;
        }

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            else
            {
                List<Product> list = new List<Product>();
                list = Trunk.ToList();
                list.Add(product);
                Trunk = list.AsReadOnly();
            }
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            else
            {
                List<Product> list = new List<Product>();
                list = Trunk.ToList();
                var product = list.Last();
                list.Remove(list.Last());
                Trunk = list.AsReadOnly();
                return product;
            }
        }
    }
}
