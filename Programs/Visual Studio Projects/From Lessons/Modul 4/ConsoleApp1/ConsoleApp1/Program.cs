using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string command = Console.ReadLine();
            string previous = command;

            while (command.ToLower() != "exit")
            {
                if (command == "back")
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Pop());
                    }
                    previous = null;
                }
                else
                {
                    if (previous != null)
                    {
                        stack.Push(previous);
                    }
                    previous = command;
                }
                command = Console.ReadLine();
            }
        }
    }
}
