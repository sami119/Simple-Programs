using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    class Triangle : ColoredFigure
    {
        private const string name = "Triangle";
        public Triangle(string color, int size) : base(color, size)
        {

        }
        public override double GetArea()
        {
            return ((Size * Size) * Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            return name;
        }
    }
}
