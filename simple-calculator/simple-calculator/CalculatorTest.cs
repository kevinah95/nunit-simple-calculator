using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace simple_calculator.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator sut; //SetUp Object (First instance)
        [OneTimeSetUp]
        public void TestSetup()

        {
            sut = new Calculator();
        }

        [Test]
        public void ShouldSumTwoNumbers()
        {
            double expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldDifTwoNumbers()
        {
            double expectedResult = sut.Sub(8, 7);
            Assert.That(expectedResult, Is.EqualTo(1));
        }

        [Test]
        public void ShouldDivTwoNumbers()
        {
            double expectedResult = sut.Div(8, 2);
            Assert.That(expectedResult, Is.EqualTo(4));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            double expectedResult = sut.Mul(8, 2);
            Assert.That(expectedResult, Is.EqualTo(16));
        }


        [Test]
        public void ShouldSumTwoNegativeNumbers()
        {
            double expectedResult = sut.Add(-7, -8);
            Assert.That(expectedResult, Is.EqualTo(-15));
        }

        [Test]
        public void ShouldDifTwoNegativeNumbers()
        {
            double expectedResult = sut.Sub(-8, -7);
            Assert.That(expectedResult, Is.EqualTo(-1));
        }

        [Test]
        public void ShouldDivTwoNegativeNumbers()
        {
            double expectedResult = sut.Div(-8, -2);
            Assert.That(expectedResult, Is.EqualTo(4));
        }

        [Test]
        public void ShouldMulTwoNegativeNumbers()
        {
            double expectedResult = sut.Mul(-8, -2);
            Assert.That(expectedResult, Is.EqualTo(16));
        }

        [Test]
        public void ShouldSumTwoDoubles()
        {
            double expectedResult = sut.Add(6.3, 0.2);
            Assert.That(expectedResult, Is.EqualTo(6.5));
        }

        [Test]
        public void ShouldDifTwoDoubles()
        {
            double expectedResult = sut.Sub(6.3, 0.2);
            Assert.That(expectedResult, Is.EqualTo(6.1));
        }

        [Test]
        public void ShouldDivTwoDoubles()
        {
            double expectedResult = sut.Div(6.3, 0.2);
            Assert.That(expectedResult, Is.EqualTo(31.499999999999996d));
        }

        [Test]
        public void ShouldMulTwoDoubles()
        {
            double expectedResult = sut.Mul(6.3, 0.2);
            Assert.That(expectedResult, Is.EqualTo(1.26));
        }

        //Test documented
        [Test]
        public void ShouldDivisionByZero()
        {
            Assert.That(() => sut.Div(6, 0),
                Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void ShouldPositiveOverflow()
        {
            double expectedResult = sut.Add(double.MaxValue, double.MaxValue);
            Assert.That(expectedResult, Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void ShouldNegativeOverflow()
        {
            double expectedResult = sut.Add(double.MinValue, double.MinValue);
            Assert.That(expectedResult, Is.EqualTo(double.NegativeInfinity));
        }

        [Test]
        public void ShouldConvertedToValidInput()
        {
            double expectedResult = sut.ConvertToValidInput("2,4");
            Assert.That(expectedResult, Is.EqualTo(2.4));
        }

        [Test]
        public void ShouldOperateWithPreviousResult()
        {
            double previousResult = sut.Add(2, 3);
            double expectedResult = sut.Add(previousResult,5);
            Assert.That(expectedResult, Is.EqualTo(10));
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}
