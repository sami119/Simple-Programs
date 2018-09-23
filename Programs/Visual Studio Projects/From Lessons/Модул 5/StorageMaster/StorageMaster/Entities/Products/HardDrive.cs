using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        private const double weight = 1;
        public HardDrive(double price) : base(price, weight)
        {
        }
    }
}
