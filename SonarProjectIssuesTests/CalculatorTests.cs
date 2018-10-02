using System;
using NUnit.Framework;
using SonarProjectIssues;

namespace SonarProjectIssuesTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator = new Calculator();
        private int unused;

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(5, calculator.Add(3, 2));
        }

        [Test]
        public void TestSubstract()
        {
            Assert.AreEqual(1, calculator.Substract(3, 2));
            Assert.AreEqual(-1, calculator.Substract(3, 4));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(6, calculator.Multiply(3, 2));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(1, calculator.Divide(3, 2));
        }

        [Test]
        public void TestDivideByZero()
        {
            Assert.Throws(typeof(DivideByZeroException), () =>
            {
                calculator.Divide(3, 0);
            });
        }
    }
}
