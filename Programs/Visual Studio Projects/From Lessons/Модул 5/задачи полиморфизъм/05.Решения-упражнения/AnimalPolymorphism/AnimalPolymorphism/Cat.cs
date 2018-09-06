using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism
{
    class Cat : IAnimal
    {

        public void Perform()
        {
            MakeNoise();
            MakeTrick();
        }

        public void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }

        public void MakeTrick()
        {
            Console.WriteLine("No trick for you! I'm too lazy!");
        }
    }
}
