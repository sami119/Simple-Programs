using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism
{
    class Dog : IAnimal
    {
        public void Perform()
        {
            MakeNoise();
            MakeTrick();
        }

        public void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public void MakeTrick()
        {
            Console.WriteLine("Hold my paw, human!");
        }
    }
}
