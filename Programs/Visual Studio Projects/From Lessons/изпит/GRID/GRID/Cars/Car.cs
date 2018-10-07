using GRID.Tyres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Cars
{
    class Car
    {
        private int hp;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                this.hp = value;
            }
        }

        private double fuelAmount;
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                if (value > 160)
                {
                    fuelAmount = 160;
                }
                else
                {
                    this.fuelAmount = value;
                }                
            }
        }


        private Tyre tyre;
        public Tyre Tyre
        {
            get
            {
                return tyre;
            }
            protected set
            {
                this.tyre = value;
            }
        }

        public Car(int hp, double fuelAmount, double tyreHardness, double grip)
        {
            this.hp = hp;
            this.fuelAmount = fuelAmount;
            tyre = new UltrasoftTyre(tyreHardness, grip);
        }

        public Car(int hp, double fuelAmount, double tyreHardness)
        {
            this.hp = hp;
            this.fuelAmount = fuelAmount;
            tyre = new HardTyre(tyreHardness);
        }
    }
}
