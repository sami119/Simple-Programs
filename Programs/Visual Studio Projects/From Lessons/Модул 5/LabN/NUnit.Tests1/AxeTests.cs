using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LabN;

namespace NUnit.Tests1
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilyAfterAttack()
        {
            // arange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // act
            axe.Attack(dummy);
            var result = axe.DurabilityPoints;

            // assert
            Assert.AreEqual(9, result);
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
