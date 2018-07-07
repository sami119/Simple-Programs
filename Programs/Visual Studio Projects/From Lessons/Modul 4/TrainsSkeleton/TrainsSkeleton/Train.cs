using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainsSkeleton
{
    class Train
    {
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }

        private int cars;
        public int Cars
        {
            get
            {
                return cars;
            }
            set
            {
                this.cars = value;
            }
        }

        //Constructor
        public Train(int number, string name, string type, int cars)
        {
            this.number = number;
            this.name = name;
            this.type = type;
            this.cars = cars;
        }

        public override string ToString()
        {
            return Number + " " + Name + " " + Type + " " + Cars;
        }
    }
}
