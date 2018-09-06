using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism
{
    interface IAnimal : IMakeNoise, IMakeTrick
    {
        void Perform();
    }
}
