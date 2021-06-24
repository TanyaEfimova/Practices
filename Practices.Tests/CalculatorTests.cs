using NUnit.Framework;
using System;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Additional(2, 4) == 6);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Subtraction(2, 4) == -2);
        }

        [Test]
        public void MultiplicationMustReturnExpectedValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(2, 4), Is.EqualTo(8));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Division(2, 4) == 0);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(2, 0));
        }
    }
}
