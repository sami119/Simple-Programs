using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            if (arr.Contains(n))
            {
                Console.WriteLine("{0} Exists in the List", n);
            }
            else
            {
                Console.WriteLine("{0} Not exists in the List", n);
            }

            Console.ReadKey();
        }
    }
}
