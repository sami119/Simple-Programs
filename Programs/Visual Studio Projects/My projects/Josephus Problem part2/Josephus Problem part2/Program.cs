using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void People(int n)
        {
            List<int> person = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                person.Add(i);
            }

            while (person.Count != 1)
            {
                Console.Write("person: {0} --> kills person{1}\n", person[0], person[1]);
                person.RemoveAt(1);
                person.Insert(person.Count, person[0]);
                person.RemoveAt(0);
            }
            Console.Write("alive person: {0}", person[0]);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.Write("people: {0}\n", n);
                People(n);
            }
            else
            {
                Console.Write("invalid input");
            }

            Console.ReadKey();
        }
    }
}

/*
Coding challenge

Josephus Problem

N people (numbered 1 to N) are standing in a circle. Person 1 kills Person 2 with a sword and gives it to Person 3. Person 3 kills Person 4 and gives the sword to Person 5. This process is repeated until only one person is alive.

Task:
(Medium) Given the number of people N, write a program to find the number of the person that stays alive at the end.
(Hard) Show each step of the process.
*/
