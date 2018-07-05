using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 10, 3, 6 };
            Selection.Sort(arr);
            Console.WriteLine(string.Join(",", arr));

        }
    }
}
