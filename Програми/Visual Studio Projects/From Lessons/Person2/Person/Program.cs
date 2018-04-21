using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        public static void Main()
        {
            var persons = new List<Person>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            var bonus = double.Parse(Console.ReadLine());

            //persons.ForEach(p => p.IncreaseSalary(bonus));
            foreach(var p in persons)
            {
                p.IncreaseSalary(bonus);
            }

            //persons.ForEach(p => Console.WriteLine(p.ToString()));
            foreach(var p in persons)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }
    }
}
