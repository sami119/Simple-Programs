using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int br = 0, num = 0, maxNum = 0, maxBr = 0;
            num = arr[0];
            br = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    br++;
                }
                else if(br > maxBr)
                {
                    maxBr = br;
                    maxNum = num;
                    num = arr[i];
                    br = 1;         
                }
            }

            if (br > maxBr)
            {
                maxBr = br;
                maxNum = num;
            }

            for (int i = 0; i < maxBr; i++)
            {
                Console.Write("{0} ", maxNum);
            }

            Console.ReadKey();
        }
    }
}
