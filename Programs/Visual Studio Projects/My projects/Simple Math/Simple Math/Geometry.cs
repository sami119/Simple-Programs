using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Maths
{
    static class Geometry
    {
        // sin T Method - To Longer, have to be smallest.
        public static void SinT()
        {
            //some variables used below
            double angle;
            double R;

            //initcialization of an side and his value.
            Console.Write("Please enter a, b or c and his value: ");
            string[] input = Console.ReadLine().Split(' ').ToArray(); // [0]-type(a,b,c) [1]-value

            // choise
            if (input[0].ToLower() == "a")
            {
                var a = double.Parse(input[1]);// a value

                // angle alpha value
                Console.Write("Enter the value of angle alpha: ");
                angle = double.Parse(Console.ReadLine());

                R = (double.Parse(input[1]) / Math.Sin(angle)) / 2;

                // new input
                Console.Write("Enter another angle or side of this triangle and his value: ");
                input = Console.ReadLine().Split(' ').ToArray();

                switch(input[0].ToLower()) // my favorite switch case ;)
                {
                    case "b":
                        Console.WriteLine("beta = " + (double.Parse(input[1]) * Math.Sin(angle)) / a);
                        break;
                    case "c":
                        Console.WriteLine("gama = " + (double.Parse(input[1]) * Math.Sin(angle)) / a);
                        break;
                    case "beta":
                        Console.WriteLine("b = " + (a * Math.Sin(double.Parse(input[1]))) / Math.Sin(angle));
                        break;
                    case "gama":
                        Console.WriteLine("c = " + (a * Math.Sin(double.Parse(input[1]))) / Math.Sin(angle));
                        break;
                }

                // R value
                Console.WriteLine("R = " + R);
            }

            else if (input[0].ToLower() == "b")
            {
                var b = double.Parse(input[1]);// b value

                Console.Write("Enter the value of angle beta: ");
                angle = double.Parse(Console.ReadLine());

                R = (double.Parse(input[1]) / Math.Sin(angle)) / 2;

                Console.Write("Enter another angle or side of this triangle and his value: ");
                input = Console.ReadLine().Split(' ').ToArray();

                switch (input[0].ToLower()) // my favorite switch case ;)
                {
                    case "a":
                        Console.WriteLine("alpha = " + (double.Parse(input[1]) * Math.Sin(angle)) / b);
                        break;
                    case "c":
                        Console.WriteLine("gama = " + (double.Parse(input[1]) * Math.Sin(angle)) / b);
                        break;
                    case "alpha":
                        Console.WriteLine("a = " + (b * Math.Sin(double.Parse(input[1]))) / Math.Sin(angle));
                        break;
                    case "gama":
                        Console.WriteLine("c = " + (b * Math.Sin(double.Parse(input[1]))) / Math.Sin(angle));
                        break;
                }

                Console.WriteLine("R = " + R);
            }

            else if (input[0].ToLower() == "c")
            {
                var c = double.Parse(input[1]);// c value

                Console.Write("Enter the value of angle gama: ");
                angle = double.Parse(Console.ReadLine());

                R = (double.Parse(input[1]) / Math.Sin(angle)) / 2;

                Console.WriteLine("Enter another angle or side of this triangle and his value: ");
                input = Console.ReadLine().Split(' ').ToArray();

                switch (input[0].ToLower()) // my favorite switch case ;)
                {
                    case "a":
                        Console.WriteLine("alpha = " + (double.Parse(input[1]) * Math.Sin(angle)) / c);
                        break;
                    case "b":
                        Console.WriteLine("beta = " + (double.Parse(input[1]) * Math.Sin(angle)) / c);
                        break;
                    case "alpha":
                        Console.WriteLine("a = " + (c * Math.Sin(double.Parse(input[1]))) / Math.Sin(angle));
                        break;
                    case "beta":
                        Console.WriteLine("b = " + (c * Math.Sin(double.Parse(input[1]))) / Math.Sin(angle));
                        break;
                }

                Console.WriteLine("R =" + R);
            }
        }

        //cos T Method
        public static void CosT()
        {
            // search string
            Console.Write("Enter what you search: ");
            var input = Console.ReadLine();

            if(input.ToLower() == "a")
            {
                double a; // variable of a

                Console.Write("Enter the value of b: ");
                var b = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of c: ");
                var c = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle alpha: ");
                var angle = double.Parse(Console.ReadLine());

                a = Math.Sqrt((b * b) + (c * c) - (2 * b * c * Math.Cos(angle)));
                Console.WriteLine("a = " + a);
            }

            else if (input.ToLower() == "b")
            {
                double b; // variable of b

                Console.Write("Enter the value of a: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of c: ");
                var c = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle beta: ");
                var angle = double.Parse(Console.ReadLine());

                b = Math.Sqrt((a * a) + (c * c) - (2 * a * c * Math.Cos(angle)));
                Console.WriteLine("b = " + b);
            }

            else if (input.ToLower() == "c")
            {
                double c; // variable of c

                Console.Write("Enter the value of a: ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                var b = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle gama: ");
                var angle = double.Parse(Console.ReadLine());

                c = Math.Sqrt((a * a) + (b * b) - (2 * a * b * Math.Cos(angle)));
                Console.WriteLine("c = " + c);
            }
        }
    }
}
