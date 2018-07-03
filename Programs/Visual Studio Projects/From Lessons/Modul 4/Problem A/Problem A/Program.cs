using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n> 101)
            {
                throw new ArgumentException();
            }

            List<int> arr = new List<int>();

            Queue<int> queue = new Queue<int>();

            var list = new List<int>();

            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach(var element in list)
            {
                queue.Enqueue(element);
            }

            foreach (var element in queue)
            {
                if (element % 2 == 1)
                {
                    arr.Add(element);
                }
            }

            foreach (var element in queue)
            {
                if (element % 2 == 0)
                {
                    arr.Add(element);
                }
            }
            Console.WriteLine(String.Join(" ", arr)+" ");
        }
    }
}
