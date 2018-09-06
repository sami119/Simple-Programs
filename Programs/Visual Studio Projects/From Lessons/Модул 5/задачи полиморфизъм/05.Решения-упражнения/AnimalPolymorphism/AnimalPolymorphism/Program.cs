using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Trainer trainer = new Trainer(dog);
            trainer.Make();
            trainer.Entity = cat;
            trainer.Make();
        }
    }
}
