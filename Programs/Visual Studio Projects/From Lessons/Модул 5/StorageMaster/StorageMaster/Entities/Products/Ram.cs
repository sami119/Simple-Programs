using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    public class Ram : Product
    {
        private const double weight = 0.1;
        public Ram(double price) : base(price, weight)
        {
        }
    }
}
