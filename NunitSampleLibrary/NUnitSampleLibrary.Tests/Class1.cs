using NUnit.Framework;
using NunitSampleLibrary;
using System;
using System.Linq;

namespace NUnitSampleLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumberTest()
        {
            var calculator = new Calculator();
            int result = calculator.Add(10, 50);
            Assert.AreEqual(60, result);
        }
    }
}
