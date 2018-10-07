using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRID.Tyres
{
    class HardTyre : Tyre
    {
        private const string name = "Hard";
        public HardTyre(double hardness):base(name, hardness)
        {
        }
    }
}
