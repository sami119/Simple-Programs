using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class BankAcountTests
    {
        [Test]
        public void AcountInitializeWithPositiveValue()
        {
            BankAcount acount = new BankAcount(2000m);
            Assert.AreEqual(2000m, acount.Amount);
        }
    }
}
