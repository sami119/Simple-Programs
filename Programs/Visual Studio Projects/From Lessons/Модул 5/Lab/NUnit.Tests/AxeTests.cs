using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(1, axe.DurabilityPoints, "Axe Durability doesnt change after attack");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(20, 20);
            //Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
