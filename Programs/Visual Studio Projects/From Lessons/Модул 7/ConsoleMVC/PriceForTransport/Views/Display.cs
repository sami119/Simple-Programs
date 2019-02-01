using System;
using System.Collections.Generic;
using System.Text;

namespace PriceForTransport.Views
{
    class Display
    {
        public int n { get; set; }
        public string Time { get; set; }
        public double Price { get; set; }

        public Display()
        {
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter km: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day or night: ");
            Time = Console.ReadLine();
            while (!CheckedTime())
            {
                Console.WriteLine("Your input is invalid! Enter day or night: ");
                Time = Console.ReadLine();
            }
        }

        private bool CheckedTime()
        {
            if (this.Time.ToLower() == "day" || this.Time.ToLower() == "night")
            {
                return true;
            }
            return false;
        }

        public void ShowPrice()
        {
            Console.WriteLine("Your price is: {0:C}", Price);
        }
    }
}
