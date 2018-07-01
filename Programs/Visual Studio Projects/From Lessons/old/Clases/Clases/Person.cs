using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Person
    {
        // constructor
        public Person()
        {
            counter++;
        }

        // private variables
        private string name;
        private int age;

        // public variables
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // counter
        private static int counter;

        public static int Counter
        {
            get { return counter; }
        }
    }
}
