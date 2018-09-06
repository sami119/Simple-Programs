using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    public abstract class ColoredFigure
    {
        public  string Color { get; set; }
        public int Size { get; set; }

        public ColoredFigure(string color, int size)
        {
            this.Color = color;
            this.Size = size;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1}", this.Color, this.Size);
        }

        public abstract string GetName();
        public abstract double GetArea();
    }
}
