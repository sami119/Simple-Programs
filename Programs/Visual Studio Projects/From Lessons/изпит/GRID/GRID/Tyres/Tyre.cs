using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Tyres
{
    abstract class Tyre
    {
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

        private double hardness;
        public double Hardness
        {
            get
            {
                return hardness;
            }
            set
            {              
                this.hardness = value;
            }
        }

        private double degradation;//довърши
        public double Degradation
        {
            get
            {
                return degradation;
            }
            set
            {
                this.degradation = value;
            }
        }

        protected Tyre(string name, double hardness)
        {
            this.name = name;
            this.hardness = hardness;
            this.degradation = 100;
        }

        public virtual void DegradationPerLap()
        {
            if (degradation<0)
            {
                throw new Exception();
            }
            degradation -= hardness;
        }
    }
}
