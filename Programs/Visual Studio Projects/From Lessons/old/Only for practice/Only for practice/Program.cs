using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Only_for_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // counter
            int n = int.Parse(Console.ReadLine());
            // our list
            List<int> nums = new List<int>();

            //loop
            for (int i = 0; i<n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            foreach(var num in nums)
            {
                Console.WriteLine(SqrtN(num));
            }
        }
    }
}
