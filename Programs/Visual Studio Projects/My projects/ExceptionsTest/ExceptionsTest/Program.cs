using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises exercise = new Exercises();

            //7
            //exercise.ExSeven();

            //8
            //exercise.ExEight();

            //9
            //Console.WriteLine(exercise.ExNine());

            //10
            exercise.ExTen();
            Console.WriteLine(exercise.bytes.ToString());
            Console.ReadKey();

        }
    }
}
