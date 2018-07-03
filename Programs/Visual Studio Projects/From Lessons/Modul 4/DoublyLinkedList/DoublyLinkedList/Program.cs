using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddFirst(8);
            list.AddFirst(9);
            list.AddFirst(18);
            list.AddLast(28);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
