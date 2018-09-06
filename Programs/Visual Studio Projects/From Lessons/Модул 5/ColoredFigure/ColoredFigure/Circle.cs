using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    class Circle : ColoredFigure
    {
        private const string name = "Circle";
        public Circle(string color, int size): base(color, size)
        {

        }
        public override double GetArea()
        {
            return Math.PI * Size * Size;
        }

        public override string GetName()
        {
            return name;
        }
    }
}
