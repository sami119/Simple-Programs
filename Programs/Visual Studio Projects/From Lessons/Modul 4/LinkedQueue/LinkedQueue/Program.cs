using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<String> q = new LinkedQueue<string>();
            q.Enqueue("Gosho");
            q.Enqueue("Misho");
            q.Enqueue("Mima");
            q.Enqueue("Pesho");
            Console.WriteLine("People waiting:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            try
            {
                Console.WriteLine("This person passed the queue: " + q.Dequeue());
                Console.WriteLine("This person passed the queue: " + q.Dequeue());
                Console.WriteLine("This person passed the queue: " + q.Dequeue());
                Console.WriteLine("This person passed the queue: " + q.Dequeue());
                Console.WriteLine("This person passed the queue: " + q.Dequeue());
                Console.WriteLine("This person passed the queue: " + q.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
