using ConsoleMVC.Models;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Controllers
{
    class TipCalculatorController
    {
        private Tip tip;
        private Display display;

        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
