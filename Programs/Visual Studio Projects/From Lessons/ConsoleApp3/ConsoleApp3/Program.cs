using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static double ConvertToBgn(double sum, double convert)
        {
            var output = sum * convert;
            return output;
        }

        public static double ConvertFromBgn(double sum, double convert)
        {
            var output = sum / convert;
            return output;
        }

        static void Main(string[] args)
        {
            //input variables
            var sum = double.Parse(Console.ReadLine());
            var currency1 = Console.ReadLine();
            var currency2 = Console.ReadLine();

            //some variables
            var USD = 1.79549;
            var EUR = 1.95583;
            var GBP = 2.53405;

            //output variables
            var output = 0.00;

            //cases
            switch (currency1.ToUpper())
            {
                case "BGN":
                    {
                        if (currency2 == "USD")
                        {
                            output = ConvertFromBgn(sum, USD);
                        }
                        if (currency2 == "EUR")
                        {
                            output = ConvertFromBgn(sum, EUR);
                        }
                        if (currency2 == "GBP")
                        {
                            output = ConvertFromBgn(sum, GBP);
                        }
                        break;
                    }
                case "USD":
                    {
                        output = ConvertToBgn(sum, USD);

                        if (currency2 == "BGN")
                        {
                            break;
                        }
                        else if (currency2 == "EUR")
                        {
                            output = ConvertFromBgn(output, EUR);
                        }
                        else if (currency2 == "GBP")
                        {
                            output = ConvertFromBgn(output, GBP);
                        }
                        break;
                    }
                case "EUR":
                    {
                        output = ConvertToBgn(sum, EUR);

                        if (currency2 == "BGN")
                        {
                            break;
                        }
                        else if (currency2 == "USD")
                        {
                            output = ConvertFromBgn(output, USD);
                        }
                        else if (currency2 == "GBP")
                        {
                            output = ConvertFromBgn(output, GBP);
                        }
                        break;
                    }
                case "GBP":
                    {
                        output = ConvertToBgn(sum, GBP);

                        if (currency2 == "BGN")
                        {
                            break;
                        }
                        else if (currency2 == "EUR")
                        {
                            output = ConvertFromBgn(output, EUR);
                        }
                        else if (currency2 == "USD")
                        {
                            output = ConvertFromBgn(output, USD);
                        }
                        break;
                    }
            }

            //output
            Console.WriteLine("{0:F2} {1}", output, currency2.ToUpper());

            Console.ReadKey();
        }
    }
}
