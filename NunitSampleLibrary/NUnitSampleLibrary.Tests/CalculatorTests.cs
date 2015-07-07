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
    }
}
