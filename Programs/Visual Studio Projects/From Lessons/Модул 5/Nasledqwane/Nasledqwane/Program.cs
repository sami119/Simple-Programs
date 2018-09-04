using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqwane
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Dog dog = new Dog(name);
            dog.Bark();
            dog.Eat();
        }
    }
}
