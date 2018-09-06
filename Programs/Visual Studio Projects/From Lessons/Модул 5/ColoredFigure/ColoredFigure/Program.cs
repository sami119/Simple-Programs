using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var counter = 0;
            var n = int.Parse(Console.ReadLine());
            List<string> list = Console.ReadLine().Split(' ').ToList(); 
            while (IsTrue(counter, n))
            {
                if (list[0] == "Triangle")
                {
                    Triangle trianngle = new Triangle(list[1], int.Parse(list[2]));
                    Console.WriteLine(trianngle.GetName()+":");
                    Console.WriteLine("Color: " + trianngle.Color);
                    Console.WriteLine("Size: " + trianngle.Size);
                    Console.WriteLine("Area: {0:F2}", trianngle.GetArea());
                }
                else if (list[0] == "Circle")
                {
                    Circle circle = new Circle(list[1], int.Parse(list[2]));
                    Console.WriteLine(circle.GetName() + ":");
                    Console.WriteLine("Color: " + circle.Color);
                    Console.WriteLine("Size: " + circle.Size);
                    Console.WriteLine("Area: {0:F2}", circle.GetArea());
                }
                if (list[0] == "Square")
                {
                    Square square = new Square(list[1], int.Parse(list[2]));
                    Console.WriteLine(square.GetName() + ":");
                    Console.WriteLine("Color: " + square.Color);
                    Console.WriteLine("Size: " + square.Size);
                    Console.WriteLine("Area: {0:F2}", square.GetArea());
                }
                list = Console.ReadLine().Split(' ').ToList();
                counter++;
            }
        }

        private static bool IsTrue(int counter, int n)
        {
            return counter < n;
        }
    }
}
