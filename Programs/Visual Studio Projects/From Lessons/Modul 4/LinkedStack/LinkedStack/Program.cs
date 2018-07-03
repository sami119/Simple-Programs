using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> digits = new LinkedStack<int>();
            var num = int.Parse(Console.ReadLine());
            Console.Write(num+"(10) = ");
            while (num != 0)
            {
                digits.Push(num % 2);
                num /= 2;
            }
            while (digits.Count > 0)
            {
                Console.Write(digits.Pop());
            }
            Console.WriteLine("(2)");
        }
    }
}
