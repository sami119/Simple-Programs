using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // input variable
            string input;

            // 1st menu loop
            for (; ;)
            {
                MhetodClass.Menu();
                input = Console.ReadLine();
                MhetodClass.TryCatch(input);

                // Our choise
                if(input.ToUpper() == "A")
                {
                    // 2nd menu loop
                    for(; ; )
                    {
                        MhetodClass.AlgebraMenu();
                        input = Console.ReadLine();
                        MhetodClass.TryCatch(input);

                        // Our choise
                        if(input.ToUpper() == "Q")
                        {
                            Algebra.QuadraticEquation();
                        }

                        if (input.ToUpper() == "V")
                        {
                            Algebra.Viet();
                        }

                        if (input.ToUpper() == "U")
                        {
                            break;
                        }
                    }
                }

                if(input.ToUpper() == "G")
                {
                    // 2nd menu loop
                    for(; ; )
                    {
                        MhetodClass.GeometryMenu();
                        input = Console.ReadLine();
                        MhetodClass.TryCatch(input);

                        // Our choise
                        if (input.ToUpper() == "S")
                        {
                            Geometry.SinT();
                        }

                        if (input.ToUpper() == "C")
                        {

                        }

                        if (input.ToUpper() == "M")
                        {

                        }

                        if (input.ToUpper() == "B")
                        {

                        }

                        if (input.ToUpper() == "U")
                        {
                            break;
                        }
                    }
                }

                if(input.ToUpper() == "E")
                {
                    break;
                }
            }
            Console.WriteLine("Thanks for using my program.");
            Console.ReadKey();
        }
    }
}
