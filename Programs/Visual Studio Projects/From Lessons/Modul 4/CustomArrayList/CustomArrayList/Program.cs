using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList arrList = new CustomArrayList();
            arrList.Add("ivan");
            arrList.Add("ivancho");
            arrList.Add("ivanchoto");

            arrList.Insert(1, "Marijka");
            for (int i = 0; i < arrList.Count; i++) Console.WriteLine(arrList.Get(i));
            Console.ReadKey();
        }
    }
}
