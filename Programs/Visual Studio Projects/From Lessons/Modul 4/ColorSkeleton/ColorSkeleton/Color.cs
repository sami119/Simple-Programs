using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSkeleton
{
    class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        public override string ToString()
        {
            return "(" + Red + ", " + Green + ", " + Blue + ")";
        }

        public int CalculatePoints()
        {

            throw new NotImplementedException();
        }
    }
}
