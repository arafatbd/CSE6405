using NUnit.Framework;
using SoftwareTestingAssignment;

namespace NUnitFactorialTest
{
    [TestFixture]
    public class Tests
    {
        public Factorial factorial;

        [SetUp]
        public void Setup()
        {
            factorial = new Factorial();
        }

        [Test]
        public void NegFactorialReturnsOne()
        {
            Assert.AreEqual(1, factorial.GetFactorial(-5));
        }

        [Test]
        public void ZeroFactorialReturnsOne()
        {
            Assert.AreEqual(1, factorial.GetFactorial(0));
        }

        [Test]
        public void OneFactorialReturnsOne()
        {
            Assert.AreEqual(1, factorial.GetFactorial(1));
        }

        [Test]
        public void FiveFactorialReturns120()
        {
            Assert.AreEqual(120, factorial.GetFactorial(5));
        }

        [Test]
        public void TenFactorialReturns3628800()
        {
            Assert.AreEqual(3628800, factorial.GetFactorial(10));
        }
    }
}