using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            var n = int.Parse(Console.ReadLine()); //number of people

            //some variables
            var list = new List<int>();  //array that will store the values
            var lastNum = 0;
            var listForNums = new List<int>();

            //loop
            for (int i = 1; i < n; i++)
            {
                list.Add(i);
            }

            lastNum = list[list.Count - 1];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    listForNums.Add(list[i]);
                }
            }

            foreach(var lis in listForNums)
            {
                list.Remove(lis);
            }

            while (list.Count != 1)
            { 
                if(list.Contains(lastNum))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if(i % 2 == 0)
                        {
                            listForNums.Add(list[i]);
                        }
                    }     
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i % 2 == 1)
                        {
                            listForNums.Add(list[i]);
                        }
                    }
                }

                foreach (var lis in listForNums)
                {
                    list.Remove(lis);
                }

                if (list.Count != 1)
                {
                    lastNum = list[list.Count - 1];
                }
                
            }

            Console.WriteLine(String.Join(" ", list));
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
