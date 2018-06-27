using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = 0;

            //tries if the number is greater than 100 and less than 2, and if is true, throw exeption
            try
            {
                N = int.Parse(Console.ReadLine());
                if (N<2 || N>100)
                {
                    throw new ArgumentException();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("2<=N<=100");
            }

            Console.WriteLine(new string('*', N));
            for (int i = 0; i < N-2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', N - 2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', N));
            Console.ReadKey();
        }
    }
}
