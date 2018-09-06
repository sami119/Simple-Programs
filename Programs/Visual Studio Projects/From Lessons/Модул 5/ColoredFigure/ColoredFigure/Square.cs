using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    class Square : ColoredFigure
    {
        private const string name = "Square";
        public Square(string color, int size): base(color, size)
        {

        }

        public override double GetArea()
        {
            return Size * Size;
        }

        public override string GetName()
        {
            return name;
        }
    }
}
