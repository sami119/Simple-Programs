using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Tyres
{
    class UltrasoftTyre : Tyre
    {
        private double grip;
        public double Grip
        {
            get
            {
                return grip;
            }
            set
            {
                this.grip = value;
            }
        }

        private const string name = "Ultrasoft";

        public UltrasoftTyre(double hardness, double grip) : base(name, hardness)
        {
            this.grip = grip;
        }

        public override void DegradationPerLap()
        {
            if(base.Degradation < 30)
            {
                throw new Exception();
            }
            Degradation -= Hardness + Grip;
        }
    }
}
