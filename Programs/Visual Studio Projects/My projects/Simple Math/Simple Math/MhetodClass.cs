using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Math
{
    static class MhetodClass // a class with basic methods
    {
        // Menu
        public static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Choose from the options below.");
            Console.WriteLine("(A)lgebra");
            Console.WriteLine("(G)eometry");
            Console.WriteLine("(E)xit");
        }

        // Algebra Menu
        public static void AlgebraMenu()
        {
            Console.WriteLine("Algebra Menu:");
            Console.WriteLine("(Q)uadratic Equaton");
            Console.WriteLine("(V)iet");
            Console.WriteLine("(U)ndo");
            //More soon
        }

        // Geometry Menu
        public static void GeometryMenu()
        {
            Console.WriteLine("Geometry Menu:");
            Console.WriteLine("(S)in T");
            Console.WriteLine("(C)os T");
            Console.WriteLine("(M)edian T");
            Console.WriteLine("(B)isector T");
            Console.WriteLine("(U)ndo");
            //More soon
        }

        // Try catch method
        public static void TryCatch(string input)//this mhetod see if the input is in corect format in the Menu
        {
            try
            {
                if (input == "")
                {
                    throw new ArgumentNullException();
                }
                if (input.Length >= 2)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Your input is null. Please enter one character.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Your input is too longer. Please enter one character.");
            }
        }

    }
}