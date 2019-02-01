using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Models
{
    class Tip
    {
        private double amount;
        private double percent;

        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public double Percent
        {
            get { return this.percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;
                }
                else
                {
                    this.percent = value;
                }
            }
        }

        public Tip(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }
        public Tip() : this(0, 0) { }

        public double CalculateTip()
        {
            return Amount * Percent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
