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
                MhetodClass.Menu(); // Menu block
                input = Console.ReadLine();
                MhetodClass.TryCatch(input); // A method that see if the input is corect or no

                if(input.ToUpper() == "A")// Open Algebra Menu
                {
                    // 2nd menu loop
                    for(; ; )
                    {
                        MhetodClass.AlgebraMenu(); // Algebra Menu Block
                        input = Console.ReadLine();
                        MhetodClass.TryCatch(input);

                        // Our choise
                        if(input.ToUpper() == "Q")
                        {
                            Algebra.QuadraticEquation(); // void method
                        }

                        if (input.ToUpper() == "V")
                        {
                            Algebra.Viet(); // void method
                        }

                        if (input.ToUpper() == "U")
                        {
                            break; // fin of the loop for Algebra Menu
                        }
                    }
                }

                if(input.ToUpper() == "G") // open Geometry Menu
                {
                    // 2nd menu loop
                    for(; ; )
                    {
                        MhetodClass.GeometryMenu(); // Geometry Menu block
                        input = Console.ReadLine();
                        MhetodClass.TryCatch(input);

                        // Our choise
                        if (input.ToUpper() == "S")
                        {
                            Geometry.SinT(); //void method
                        }

                        if (input.ToUpper() == "C")
                        {
                            // coming soon
                        }

                        if (input.ToUpper() == "M")
                        {
                            // Comming soon
                        }

                        if (input.ToUpper() == "B")
                        {
                            // Coming soon
                        }

                        if (input.ToUpper() == "U")
                        {
                            break; // fin of the second menu loop
                        }
                    }
                }

                if(input.ToUpper() == "E")
                {
                    break; //exit of the program
                }
            }
            Console.WriteLine("Thanks for using my program.");
            Console.ReadKey();
        }
    }
}
