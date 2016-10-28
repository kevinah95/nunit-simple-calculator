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

        public void ShouldAddTwoNumbers()

        {
            double expectedResult = sut.Add(7, 8);

            Assert.That(expectedResult, Is.EqualTo(15));
        }
    }
}
