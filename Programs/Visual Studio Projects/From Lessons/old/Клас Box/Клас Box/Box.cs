using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клас_Box
{
    class Box
    {
        public Box(double l, double h, double w)
        {
            this.height = h;
            this.lenght = l;
            this.width = w;
        }
        private double lenght;
        private double width;
        private double height;
        /*public double Lenght
        {
            get { return this.lenght; }
            set { this.lenght = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }*/
        public double GetS()
        {
            double w = this.width;
            double l = this.lenght;
            double h = this.height;
            return 2*(l*w + l*h + w*h);
        }
        public double GetL()
        {
            double w = this.width;
            double l = this.lenght;
            double h = this.height;
            return 2 * (l + w) * h;
        }
        public double GetV()
        {
            double w = this.width;
            double l = this.lenght;
            double h = this.height;
            return l*w*h;
        }
    }
}
