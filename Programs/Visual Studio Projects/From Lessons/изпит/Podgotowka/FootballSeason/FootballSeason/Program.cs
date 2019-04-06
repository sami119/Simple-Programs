using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cmd = Console.ReadLine().Split(' ').ToList();
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            while (cmd.ToString() != "End of season")
            {
                if(cmd[0]+" "+cmd[1]+" "+cmd[2] == "End of season")
                {
                    break;
                }

                if (dict.ContainsKey(cmd[0]))
                {
                    var value = 0;
                    foreach (var el in dict)
                    {
                        if (el.Key == cmd[0])
                        {
                            value = el.Value;
                            value += int.Parse(cmd[2]);
                        }
                    }
                    dict[cmd[0]] = value;
                }
                else
                {
                    dict.Add(cmd[0], int.Parse(cmd[2]));
                }
                cmd = Console.ReadLine().Split(' ').ToList();
            }
            foreach(var el in dict)
            {
                Console.WriteLine(el.Key + " -> " + el.Value);
            }
            Console.ReadKey();
        }
    }
}
