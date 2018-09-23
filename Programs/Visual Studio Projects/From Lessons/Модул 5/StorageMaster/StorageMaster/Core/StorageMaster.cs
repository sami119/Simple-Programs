using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storage;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private Dictionary<string, Storage> storageRegistry = new Dictionary<string, Storage>();
        private Dictionary<string, Stack<Product>> productPool = new Dictionary<string, Stack<Product>>();
        private Vehicle selectedVehicle = null;

        public string AddProduct(string type, double price)
        {
            Product product;
            if(type.ToLower() == "gpu")
            {
                product = new Gpu(price);
            }
            else if(type.ToLower() == "harddrive")
            {
                product = new HardDrive(price);
            }
            else if(type.ToLower() == "ram")
            {
                product = new Ram(price);
            }
            else if (type.ToLower() == "solidstatedrive")
            {
                product = new SolidStateDrive(price);
            }
            else
            {
                throw new InvalidOperationException("Invalid product type!");
            }

            if (!productPool.ContainsKey(type))
            {
                productPool[type] = new Stack<Product>();
            }          
            productPool[type].Push(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage;
            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException("Invalid storage type!");
            }

            storageRegistry.Add(name, storage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            selectedVehicle = storageRegistry[storageName].GetVehicle(garageSlot);
            return $"Selected {selectedVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProducts = 0;
            foreach (var productName in productNames)
            {
                if (!selectedVehicle.IsFull)
                {
                    if (productPool.ContainsKey(productName))
                    {
                        if (productPool[productName].Count == 0)
                            throw new InvalidOperationException($"{productName} is out of stock!");
                        selectedVehicle.LoadProduct(productPool[productName].Pop());
                        loadedProducts++;
                    }
                    else throw new InvalidOperationException($"{productName} is out of stock!");
                }
                else break;
            }

            return $"Loaded {loadedProducts}/{productNames.Count()} products into {selectedVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!storageRegistry.ContainsKey(sourceName))
                throw new InvalidOperationException("Invalid source storage!");
            if (!storageRegistry.ContainsKey(destinationName))
                throw new InvalidOperationException("Invalid destination storage");

            int slot = storageRegistry[sourceName].SendVehicleTo(sourceGarageSlot, storageRegistry[destinationName]);

            return $"Sent {storageRegistry[destinationName].GetVehicle(slot).GetType().Name} to {destinationName} (slot {slot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            int productsInVehicle = storageRegistry[storageName].GetVehicle(garageSlot).Trunk.Count;
            int unloadedProducts = storageRegistry[storageName].UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProducts}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = storageRegistry[storageName];
            StringBuilder result = new StringBuilder();

            result.AppendLine(GetProductInfo(storage));
            result.Append(GetVehicleInfo(storage));

            return result.ToString();
        }

        public string GetSummary()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var storage in storageRegistry.OrderByDescending(x => x.Value.Products.Sum(y => y.Price)))
            {
                stringBuilder.AppendLine($"{storage.Key}:");
                stringBuilder.AppendLine($"Storage worth: ${storage.Value.Products.Sum(y => y.Price):f2}");
            }

            return stringBuilder.ToString();
        }

        private string GetProductInfo(Storage storage)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            foreach (var product in storage.Products)
            {
                if (!products.ContainsKey(product.GetType().Name))
                    products.Add(product.GetType().Name, 0);
                products[product.GetType().Name]++;
            }

            List<string> productString = new List<string>();
            foreach (var product in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                productString.Add($"{product.Key} ({product.Value})");
            }

            return $"Stock ({storage.Products.Sum(x => x.Weight)}/{storage.Capacity}): [{string.Join(", ", productString)}]";
        }

        private string GetVehicleInfo(Storage storage)
        {
            List<string> vehicleNames = new List<string>();
            foreach (var vehicle in storage.Garage)
            {
                vehicleNames.Add(vehicle == null ? "empty" : vehicle.GetType().Name);
            }

            return $"Garage: [{string.Join("|", vehicleNames)}]";
        }
    }
}
