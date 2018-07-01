using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Car
    {
        //some private variables
        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts;
        private double fuel = 100;
        private static int ordersCount = 0;

        // have to see how this is working.
        public ReadOnlyCollection<Part> Parts
        {
            get { return new ReadOnlyCollection<Part>(parts); }
        }

        //some public varaiables with get and set method
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (value.Length < 5)
                {
                    throw new FormatException("Invalid manufacturer name!");
                }
                else {
                    this.manufacturer = value;
                }
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new FormatException("Invalid model name!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double LoadCapacity
        {
            get
            {
                return loadCapacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Invalid load capacity!");
                }
                else
                {
                    this.loadCapacity = value;
                }
            }
        }

        public static int OrdersCount
        {
            set { ordersCount = value; }
            get { return ordersCount; }
        }

        // constructor
        public Car(string manufacturer, string model, double loadCapacity)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.loadCapacity = loadCapacity;
            this.parts = new List<Part>();
            ordersCount++;
        }

        //some methods
        public double GetCarPrice()
        {
            double sum = 0;
            foreach (Part p in parts)
            {
                sum += p.Price;
            }
            return sum;
        }

        public void AddPart(Part part)
        {
            parts.Add(part);
        }

        public void AddMultipleParts(List<Part> passedParts)
        {
            foreach (Part p in passedParts)
            {
                parts.Add(p);
            }
        }

        public void RemovePartByName(string name)
        {
            parts = parts.FindAll(p => p.Name != name);
        }

        public List<Part> GetPartsWithPriceAbove(double price)
        {
            return parts.FindAll(p => p.Price > price).ToList();
        }

        public Part GetMostExpensivePart()
        {
            double minPrice = 0;
            Part result = null;
            foreach (Part p in parts)
            {
                if (p.Price > minPrice)
                {
                    minPrice = p.Price;
                    result = p;
                }
            }
            return result;
        }

        public void Drive(double distance)
        {
            if ((loadCapacity * 0.2 * distance) > fuel)
            {
                throw new ArgumentException("Drive not possible!");
            }
            else
            {
                fuel = loadCapacity * 0.2 * distance;
            }
        }

        public bool ContainsPart(string partName)
        {
            foreach (Part p in parts)
            {
                if (p.Name == partName)
                {
                    return true;
                }
            }
            return false;
        }

        //ToString method
        public override string ToString()
        {
            string s;
            double price = 0;
            s = Model.ToUpper().ToString() + " made by " + Manufacturer.ToString() + "\n";
            s = s + "Available parts: \n";
            foreach (Part i in parts)
            {
                s = s + string.Format("-> {0} - {1:F2} \n", i.Name, i.Price);
                price += i.Price;
            }
            s = s + string.Format("With total price of: {0:F2} lv.", price);
            return s;
        }
    }
}
