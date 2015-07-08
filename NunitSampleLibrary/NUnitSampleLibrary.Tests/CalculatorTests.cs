using NUnit.Framework;
using NunitSampleLibrary;

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
            //Assert.AreEqual(60, result);
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void AddSubstractTest()
        {
            var calculator = new Calculator();
            int result = calculator.Substract(50, 10);
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void AddMultiplyTest()
        {
            var calculator = new Calculator();
            int result = calculator.Multiply(10, 50);
            Assert.That(result, Is.EqualTo(500));
        }

        [Test]
        public void AddDevideTest()
        {
            var calculator = new Calculator();
            int result = calculator.Device(50, 10);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
