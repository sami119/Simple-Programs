using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism
{
    class Trainer
    {
        public IAnimal Entity { get; set; }

        public Trainer(IAnimal entity)
        {
            Entity = entity;
        }

        public void Make()
        {
            Entity.Perform();
        }
    }
}
