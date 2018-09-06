using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public new static string Something()
        {
            return "Another";
        }
    }
}
