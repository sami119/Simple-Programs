using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Pair
    {
        // The elements
        public int First { get; set; }
        public int Last { get; set; }

        //Constructor: Add Values to the elements of the class
        public Pair(int first, int last)
        {
            this.First = first;
            this.Last = last;
        }

        //ToString method: returns the element ordered like (First, Last)
        public override string ToString()
        {
            return "(" + First + ", " + Last + ")";
        }

        //Difference method: returns the difference between the two elements
        public int Difference()
        {
            return Math.Abs(First - Last);//Math.Abs returns the absolute value
        }
    }
}
