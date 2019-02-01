using PriceForTransport.Views;
using PriceForTransport.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PriceForTransport.Controllers
{
    class PriceForTransportController
    {
        private Display display;
        private TheLowestPrice theLowestPrice;

        public PriceForTransportController()
        {
            display = new Display();
            theLowestPrice = new TheLowestPrice(display.n, display.Time);
            display.Price = theLowestPrice.CalculatePrice();
            display.ShowPrice();
        }
    }
}
