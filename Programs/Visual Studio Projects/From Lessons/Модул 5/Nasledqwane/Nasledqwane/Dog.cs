using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqwane
{
    public class Dog: Animal
    {
        public Dog(string name):base(name)
        {}
        public void Bark()
        {
            Console.WriteLine("The {0} is barking", base.Name);
        }
        public override void Eat()
        {
            Console.WriteLine("The {0} is eating", base.Name);
        }
    }
}
