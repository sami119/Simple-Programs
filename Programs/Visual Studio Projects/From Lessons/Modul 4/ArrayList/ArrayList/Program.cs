using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> b = new ArrayList<int>();

            b.Add(2);//0
            b.Add(3);//1
            b.Add(4);//2
            b.Add(6);//3

            for(int i = b.Count - 1;  i >= 0; i--)
            {
                Console.Write(b.Get(i)+" ");
            }

            ArrayList<string> a = new ArrayList<string>();

            Console.ReadKey();
        }
    }
}
