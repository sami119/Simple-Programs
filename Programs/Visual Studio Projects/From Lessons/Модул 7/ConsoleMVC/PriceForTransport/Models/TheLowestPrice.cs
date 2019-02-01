using System;
using System.Collections.Generic;
using System.Text;

namespace PriceForTransport.Models
{
    class TheLowestPrice
    {
        private int n;
        private string time;

        public int N
        {
            get { return this.n; }
            set { this.n = value; }
        }
        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public TheLowestPrice(int n, string time)
        {
            N = n;
            Time = time;
        }

        public double CalculatePrice()
        {
            if (n >= 100)
            {
                return n * 0.06;
            }
            else if(n >= 20)
            {
                return n * 0.09;
            }
            else
            {
                switch (time)
                {
                    case "day":
                        return 0.70 + (0.79 * n);
                    case "night":
                        return 0.70 + (0.90 * n);
                }
            }
            return 0;
        }
    }
}
