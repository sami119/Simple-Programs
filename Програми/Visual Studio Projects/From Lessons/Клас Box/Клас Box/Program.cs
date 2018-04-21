using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клас_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Box box = new Box(l, h, w);

            Console.WriteLine("Surface Area - {0:F2}", box.GetS());
            Console.WriteLine("Lateral Surface Area  - {0:F2}", box.GetL());
            Console.WriteLine("Volume - {0:F2}", box.GetV());
            Console.ReadKey();
        }
    }
}
