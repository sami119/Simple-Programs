using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Math
{
    static class Algebra
    {
        // Quadratic Equation Method
        public static void QuadraticEquation()
        {
            // a, b , c input
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            // D value
            double D = (b * b) - (4 * a * c);
            Console.WriteLine("D = " + D);

            // variables for x1, and x2
            double x1;
            double x2;

            // see what is the value of D and return the answer
            if(D < 0)
            {
                Console.WriteLine("D < 0");
                Console.WriteLine("The equation has no real roots");
            }

            else if(D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = x1;
                Console.WriteLine("x1 = x2 = " + x1);
                Console.WriteLine("The equation decomposes to {0}(x-{1})(x-{2})", a, x1, x2);
            }

            else if(D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
                Console.WriteLine("The equation decomposes to {0}(x-{1})(x-{2})", a, x1, x2);
            }
        }

        // Viet Mhetod
        public static void Viet()
        {
            // a,b,c initcialization
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());

            // The answer
            Console.WriteLine("x1 + x2 = " + -b / a);
            Console.WriteLine("x1 * x2 = " + c / a);
        }
    }
}
