using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmmetic_operations
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("(A)dd");
            Console.WriteLine("(M)ultiply");
            Console.WriteLine("(E)nd");
        }

        static void Main(string[] args)
        {
            char operation;
            int[] values = new int[2];
            for (; ;)
            {
                Menu();
                operation = char.Parse(Console.ReadLine());
                if(operation == 'E')
                {
                    break;
                }
                else if(operation == 'M')
                {
                    Console.Write("Enter two values for multiply: ");
                    values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    Console.WriteLine("The result is: " + Aritmetics.Multiply(values[0], values[1]));
                }
                else if (operation == 'A')
                {
                    Console.Write("Enter two values for Add: ");
                    values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    Console.WriteLine("The result is: " + Aritmetics.Add(values[0], values[1]));
                }
            }
        }
    }
}
