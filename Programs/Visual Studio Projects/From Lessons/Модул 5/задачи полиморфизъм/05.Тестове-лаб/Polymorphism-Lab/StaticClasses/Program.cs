using System;
using System.Collections.Generic;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Person($"{i}{i}{i}{i}{i}"));
            }

            Console.WriteLine(Person.Something());
            Console.WriteLine(Student.Something());
        }
    }
}
