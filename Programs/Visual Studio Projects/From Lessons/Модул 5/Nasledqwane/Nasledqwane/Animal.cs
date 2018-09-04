using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledqwane
{
    public class Animal
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }
}
