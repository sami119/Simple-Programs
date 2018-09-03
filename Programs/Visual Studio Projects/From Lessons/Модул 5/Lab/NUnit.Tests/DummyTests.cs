using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthWhenAttacked()
        {
            //Arrange
            Axe axe = new Axe(1, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            var oldHealth = dummy.Health;
            axe.Attack(dummy);

            //Assert
            Assert.AreNotSame(oldHealth, dummy.Health);
        }

        [Test]
        public void IsDeadDummyThrowsExceptionUnderAttack()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            // Act
            axe.Attack(dummy);

            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void IsDeadDummyGiveXP()
        {
            // Arrange           
            Dummy dummy = new Dummy(1, 1);
            Hero hero = new Hero("Коняря");

            // Act
            var xp = hero.Experience;
            hero.Attack(dummy);
            xp = hero.Experience - xp;

            // Assert
            Assert.Positive(xp);
        }

        [Test]
        public void IsAliveDummyGiveXP()
        {
            // Arrange           
            Dummy dummy = new Dummy(100, 100);
            Hero hero = new Hero("Коняря");

            // Act
            var xp = hero.Experience;
            hero.Attack(dummy);
            xp = hero.Experience - xp;

            // Assert
            Assert.Zero(xp);
        }
    }
}
